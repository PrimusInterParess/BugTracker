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
        private readonly BugTrackerDbContext _repo;
        private readonly IUserService _userUserService;
        private readonly IOrganizationService _organizationService;

        public DepartmentService(
            BugTrackerDbContext repo,
            IUserService userService,
            IOrganizationService organizationService)
        {
            this._repo = repo;
            this._userUserService = userService;
            this._organizationService = organizationService;
        }

        public bool ValidateDepartmentName(string departmentName, string organizationId)
        => this._repo
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
                _repo.Add(departmentData);
                _repo.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DepartmentViewModel GetDepartment(string departmentId)
            => this._repo
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

        public List<DepartmentServiceModel> GetAllDepartments(string organizationId)
        {
            var departments =
                _repo
                    .Organizations
                    .Include(o => o.Departments)
                    .Where(o => o.Id == organizationId)
                    .SelectMany(o => o.Departments);

            var resutl =
                departments
                    .Select(d =>
                        new DepartmentServiceModel()
                        {
                            Id = d.Id,
                            Name = d.Name,
                            DepartmentSubject = d.DepartmentSubject
                        }).ToList();

            return resutl;
        }


    }


}
