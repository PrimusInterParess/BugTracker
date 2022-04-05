using BugTracker.Infrastructure.Models;

namespace BugTracker.Core.Services
{
    using BugTracker.Infrastructure.Data.Models;
    using BugTracker.Models.ServiceModels.Department;
    using BugTracker.Models.ServiceModels.Organization;
    using Contracts;
    using Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using Models.ViewModels.Organization;

    public class OrganizationService : IOrganizationService
    {
        private readonly BugTrackerDbContext _repo;

        public OrganizationService(BugTrackerDbContext repo)
        {
            this._repo = repo;
        }

        public bool CheckIfOrganizationExistsByName(string organizationName)
        => _repo
            .Organizations
            .Any(o => o.Name == organizationName);


        public OrganizationServiceEditModel GetOrganizationById(string organizationId)
        => _repo.Organizations
            .Where(o => o.Id == organizationId)
            .Select(o =>
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

        public string GetOrganizationIdByUserId(string userId)
            => this._repo
                .Organizations
                .Include(o => o.Administrator)
                .Where(o=>o.Administrator.UserId==userId)
                .Select(o => o.Id)
                .FirstOrDefault();

        public OrganizationServiceModel GetOrganizationByUserId(string userId)
        => _repo.Organizations
                .Include(o => o.Departments)
                .Where(o => o.Administrator.UserId == userId).Select(o =>
                new OrganizationServiceModel()
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
