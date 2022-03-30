using BugTracker.Models.ServiceModels;
using BugTracker.Models.ServiceModels.Department;
using BugTracker.Models.ServiceModels.Organization;
using BugTracker.Models.ViewModels.Organization;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Core.Services
{
    using System.Security.Claims;
    using Infrastructure.Data;
    using BugTracker.Infrastructure.Data.Models;
    using Contracts;
    using Models.ViewModels.Organization;

    using static Models.Constants.MessageConstants;

    public class OrganizationService : IOrganizationService
    {
        private readonly BugTrackerDbContext _repo;

        public OrganizationService(BugTrackerDbContext repo)
        {
            this._repo = repo;
        }

        public Dictionary<string, string> ValidateOrganization(AddOrganizationFormModel organization)
        {
            var organizations =
                _repo.Organizations.FirstOrDefault(o => o.Name == organization.Name);

            var result = new Dictionary<string, string>();

            if (organizations !=null)
            {
                result.Add(nameof(organization.Name), InvalidOrganizationName);
            }

            return result;
        }

        public OrganizationServiceEditModel GetOrganizationById(string organizationId)
        {
            var organization = _repo.Organizations.Where(o => o.Id == organizationId).Select(o =>
                new OrganizationServiceEditModel()
                {
                    Id = o.Id,
                    Country = o.Country,
                    LogoUrl = o.LogoUrl,
                    StreetName = o.StreetName,
                    StreetNumber = o.StreetNumber,
                    Name = o.Name,
                    TownName = o.TownName

                }).FirstOrDefault();

            return organization;
        }

        public OrganizationVIewModel GetOrganizationByAdminId(string adminId)
        {
            var organization = _repo.Organizations
                .Include(o=>o.Departments)
                .Where(o => o.AdministratiorId == adminId).Select(o =>
                new OrganizationVIewModel()
                {
                    Id = o.Id,
                    Name = o.Name,
                    Country = o.Country,
                    TownName = o.TownName,
                    StreetName = o.StreetName,
                    StreetNumber = o.StreetNumber,
                    LogoUrl = o.LogoUrl,
                    Departments = o.Departments.Select(d => new DepartmentServiceModel()
                    {
                        Id = d.Id,
                        Name = d.Name,
                        DepartmentSubject = d.DepartmentSubject
                    }).ToList()
                }).FirstOrDefault();

            return organization;
        }

        public string Save(AddOrganizationFormModel organization, string userId)
        {
            var organizationId = string.Empty;

            Organization organizationData = new Organization()
            {
                Name = organization.Name,
                Country = organization.Country,
                StreetName = organization.StreetName,
                StreetNumber = organization.StreetNumber,
                TownName = organization.TownName,
                AdministratiorId = userId,
                LogoUrl = organization.LogoUrl
            };

            try
            {
                this._repo.Add(organizationData);
                this._repo.SaveChanges();
                organizationId = organizationData.Id;
            }
            catch (Exception)
            {
                organizationId = null;
            }

            return organizationId;
        }

       

    }
}
