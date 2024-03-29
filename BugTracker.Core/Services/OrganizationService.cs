﻿namespace BugTracker.Core.Services
{
    using BugTracker.Infrastructure.Data.Models;
    using BugTracker.Models.ServiceModels.Department;
    using BugTracker.Models.ServiceModels.Employee;
    using BugTracker.Models.ServiceModels.Organization;
    using BugTracker.Models.ServiceModels.Project;
    using Contracts;
    using Infrastructure.Data;

    public class OrganizationService : IOrganizationService
    {
        private readonly BugTrackerDbContext _data;

        public OrganizationService(BugTrackerDbContext data)
        {
            this._data = data;
        }

        public bool AlreadyExists(string organizationName, string userId)
        => _data
            .Organizations
            .Any(o =>
                o.Name == organizationName &&
                o.Administrator.UserId == userId);

        public bool Delete(string organizationId)
        {
            var organizationData = 
                _data
                .Organizations
                .FirstOrDefault(o => o.Id == organizationId);

            var deleted = _data.Remove(organizationData);

           _data.SaveChanges();

           return true;
        }


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

            var organizationData = new Organization()
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
                this._data.Add(organizationData);
                this._data.SaveChanges();
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
            => this._data.Organizations.Where(o => o.Id == organizationId).Select(o => new OrganizationServiceModel()
            {
                Id = o.Id,
                Name = o.Name,
                Country = o.Country,
                TownName = o.TownName,
                LogoUrl = o.LogoUrl,
                StreetName = o.StreetName,
                StreetNumber = o.StreetNumber,
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
        //    => this._data.Organizations.Where(o => o.Id == organizationId).Select(o => new);

        public string GetOrganizationIdByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public List<OrganizationServiceModel> GetAllOrganizationsByUser(string userId)
            => this._data.Organizations.Where(o => o.Administrator.UserId == userId).Select(o =>
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

        public bool Edit(string organizationId, string name, string country, string townName, string streetName, string streetNumber, string logoUrl)
        {
            var organizationData = _data.
                Organizations.
                Where(o => o.Id == organizationId).
                First();

            if (organizationData == null)
            {
                return false;
            }


            try
            {
                organizationData.Name = name;
                organizationData.Country = country;
                organizationData.TownName = townName;
                organizationData.StreetName = streetName;
                organizationData.StreetNumber = streetNumber;
                organizationData.LogoUrl= logoUrl;

                _data.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
                
            }

            
        }

        public string GetOrganizationNameById(string id)
            => _data.Organizations.Where(o => o.Id == id).Select(o => o.Name).FirstOrDefault();

        private string GetAdminId(string userId)
       => this
           ._data
           .Administrators
           .Where(a => a.UserId == userId)
           .Select(a => a.Id)
           .FirstOrDefault();
    }
}
