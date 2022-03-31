using BugTracker.Models.ServiceModels.Department;
using BugTracker.Models.ServiceModels.Employee;
using BugTracker.Models.ServiceModels.Project;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Core.Services
{
    using Contracts;
    using BugTracker.Infrastructure.Data.Models;
    using Models.ViewModels.Department;
    using Infrastructure.Data;

    using static Models.Constants.MessageConstants;

    public class DepartmentService : IDepartmentService
    {
        private readonly BugTrackerDbContext _repo;
        private readonly IUserService _userUserService;
        private readonly IOrganizationService _organizationService;

        public DepartmentService(BugTrackerDbContext repo, IUserService userService, IOrganizationService organizationService)
        {
            this._repo = repo;
            this._userUserService = userService;
            this._organizationService = organizationService;
        }
        public Dictionary<string, string> ValidateDepartment(AddDepartmentFormModel department)
        {
            var errors = new Dictionary<string, string>();

            var alreadyExists = this._repo.Departments.Any(d =>
                d.Name == department.Name && d.OrganizationId == department.OrganizationId);

            if (alreadyExists)
            {
                errors.Add(nameof(department.Name), InvalidDepartmentName);
            }

            return errors;

        }

        public bool Save(AddDepartmentFormModel department)
        {

            var departmentData = new Department()
            {
                Name = department.Name,
                DepartmentSubject = department.DepartmentSubject,
                OrganizationId = department.OrganizationId

            };

            try
            {
                _repo.Add(departmentData);
                _repo.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<DepartmentServiceModel> GetAllDepartments(string organizationId)
        {
            var departments = this
                ._repo
                .Organizations
                .Include(o => o.Departments)
                .Where(o => o.Id == organizationId)
                .FirstOrDefault();

            var resutl =
                this._repo
                    .Departments
                    .Include(d => d.Organization)
                    .Where(d => d.OrganizationId == organizationId)
                    .Select(d =>
                new DepartmentServiceModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    DepartmentSubject = d.DepartmentSubject
                }).ToList();

            return resutl;
        }

        public DepartmentViewModel GetDepartment(string departmentId)
        => this._repo
                .Departments
                .Include(d => d.Projects)
                .Include(d => d.DepartmentEmployees)
                .ToList()
                .Where(d => d.Id == departmentId)
                .Select(d => new DepartmentViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    DepartmentSubject = d.DepartmentSubject,
                    Projects = d.Projects.Select(p => new ProjectServiceModel()
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).OrderBy(d => d).ToList(),
                    DepartmentEmployees = d.DepartmentEmployees.Select(e => new EmployeeServiceModel()
                    {
                        Id = e.Id,
                        Name = e.Name
                    }).OrderBy(e => e).ToList()
                }).FirstOrDefault();

    }
}
