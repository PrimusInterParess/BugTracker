namespace BugTracker.Models.ServiceModels.Organization
{
    using BugTracker.Models.ServiceModels.Department;
    using BugTracker.Models.ServiceModels.Employee;
    using BugTracker.Models.ServiceModels.Project;

    public class OrganizationServiceModel
    {
        public string Id { get; init; }

        public string Name { get; init; }

        public string TownName { get; set; }

        public string Country { get; set; }

        public string LogoUrl { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        

        public ICollection<DepartmentServiceModel> Departments { get; set; } = new List<DepartmentServiceModel>();

        public ICollection<EmployeeServiceModel> Employees { get; set; } = new HashSet<EmployeeServiceModel>();

        public ICollection<ProjectServiceModel> Projects { get; set; } = new HashSet<ProjectServiceModel>();
    }
}
