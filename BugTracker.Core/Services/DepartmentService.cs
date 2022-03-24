namespace BugTracker.Core.Services
{
    using Contracts;
    using BugTracker.Infrastructure.Data.Models;
    using Models.ViewModels.Department;

    using static Models.Constants.MessageConstants;

    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository _repo;

        public DepartmentService(IRepository repo)
        {
            this._repo = repo;
        }
        public Dictionary<string, string> ValidateDepartment(AddDepartmentFormModel department)
        {
            var result = new Dictionary<string, string>();
            bool exists = this._repo.All<Department>().Any(o => o.Name == department.Name);

            //TODO: fix add department to work with organizationId instead of organization name;

            var organization = this._repo.All<Organization>().FirstOrDefault(o => o.Name == department.Organization);


            if (organization == null)
            {
                result.Add(nameof(department.Organization), InvalidOrganizationName);
            }

            if (exists)
            {
                result.Add(nameof(department.Name), InvalidDepartmentName);
            }
            //TODO: fix add department to work with organizationId instead of organization name;

            department.OrganizationId = organization.Id;

            return result;

        }

        public bool Save(AddDepartmentFormModel department)
        {

            var organization = this._repo.All<Organization>().FirstOrDefault(o => o.Name == department.Organization);

           var count = organization.Departments.Count;

            var departmentData = new Department()
            {
                Name = department.Name,
                DepartmentSubject = department.DepartmentSubject,
                OrganizationId = department.OrganizationId,
                Organization = organization

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
    }
}
