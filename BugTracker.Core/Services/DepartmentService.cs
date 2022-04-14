namespace BugTracker.Core.Services
{
    using BugTracker.Infrastructure.Data.Models;
    using BugTracker.Models.ServiceModels.Department;
    using BugTracker.Models.ServiceModels.Employee;
    using BugTracker.Models.ServiceModels.Project;
    using Contracts;
    using Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using Models.ViewModels.Department;
    using static Models.Constants.MessageConstants;

    public class DepartmentService : IDepartmentService
    {
        private readonly BugTrackerDbContext _data;
        private readonly IUserService _userUserService;
        private readonly IOrganizationService _organizationService;

        public DepartmentService(
            BugTrackerDbContext data,
            IUserService userService,
            IOrganizationService organizationService)
        {
            this._data = data;
            this._userUserService = userService;
            this._organizationService = organizationService;
        }

        public bool ValidateDepartmentName(string departmentName, string organizationId)
        => this._data
            .Departments
            .Any(d => d.Name == departmentName && d.OrganizationId == organizationId);


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
                _data.Add(departmentData);
                _data.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DepartmentViewModel GetDepartment(string departmentId)
            => this._data
                    .Departments
                    .Include(d => d.Projects)
                    .Include(d => d.DepartmentEmployees)
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

        public DepartmentListModel GetAllDepartments(string organizationId)
            => _data
                .Organizations
                .Where(o => o.Id == organizationId)
                .Select(o => new DepartmentListModel()
                {
                    OrganizationId = o.Id,
                    Departments = o.Departments.Select(d => new DepartmentServiceModel()
                    {
                        Id = d.Id,
                        Name = d.Name
                    }).ToList()
                }).FirstOrDefault();




    }


}
