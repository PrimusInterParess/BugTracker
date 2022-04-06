using BugTracker.Infrastructure.Models;
using BugTracker.Models.ServiceModels.Employee;
using BugTracker.Models.ServiceModels.Project;

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

        public bool AlreadyExists(string organizationName, string userId)
        => _repo
            .Organizations
            .Any(o =>
                o.Name == organizationName &&
                o.Administrator.UserId == userId);


        public string Save(
            string name,
            string countryName,
            string townName,
            string streetName,
            string streetNumber,
            string logoUrl,
            string userId)
        {
            var getAdminId = GetAdminId(userId);
            var organizationId = string.Empty;

            Organization organizationData = new Organization()
            {
                Name = name,
                Country = countryName,
                StreetName = streetName,
                StreetNumber = streetNumber,
                TownName = townName,
                AdministratiorId = getAdminId,
                LogoUrl = logoUrl
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

        public OrganizationServiceModel GetOrganizationByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public OrganizationServiceModel GetOrganizationById(string organizationId)
            => this._repo.Organizations.Where(o => o.Id == organizationId).Select(o => new OrganizationServiceModel()
            {
                Id = o.Id,
                Name = o.Name,
                Country = o.Country,
                TownName = o.TownName,
                LogoUrl = o.LogoUrl,
                Departments = o.Departments.Select(d => new DepartmentServiceModel()
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList(),
                Employees = o.OrganizationEmployees.Select(e => new EmployeeServiceModel()
                {
                    Id = e.Id,
                    Name = e.Name
                }).ToList(),
                Projects = o.OrganizationProjects.Select(p => new ProjectServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToList()

            }).FirstOrDefault();

        //public OrganizationFormModel GetOrganizationById(string organizationId)
        //    => this._repo.Organizations.Where(o => o.Id == organizationId).Select(o => new);

        public string GetOrganizationIdByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public List<OrganizationServiceModel> GetAllOrganizationsByUser(string userId)
            => this._repo.Organizations.Where(o => o.Administrator.UserId == userId).Select(o =>
                new OrganizationServiceModel()
                {
                    Id = o.Id,
                    Name = o.Name,
                    Country = o.Country,
                    TownName = o.TownName,
                    LogoUrl = o.LogoUrl,
                    Departments = o.Departments.Select(d => new DepartmentServiceModel()
                    {
                        Id = d.Id,
                        Name = d.Name
                    }).ToList(),
                    Employees = o.OrganizationEmployees.Select(e => new EmployeeServiceModel()
                    {
                        Id = e.Id,
                        Name = e.Name
                    }).ToList(),
                    Projects = o.OrganizationProjects.Select(p => new ProjectServiceModel()
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList()

                }).ToList();

        private string GetAdminId(string userId)
       => this
           ._repo
           .Administrators
           .Where(a => a.UserId == userId)
           .Select(a => a.Id)
           .FirstOrDefault();
    }
}
