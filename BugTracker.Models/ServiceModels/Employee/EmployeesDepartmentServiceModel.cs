namespace BugTracker.Models.ServiceModels.Employee
{
    public class EmployeesDepartmentServiceModel
    {
        public string DeparmtnetId { get; set; }
        public string OrganizationId { get; set; }

        public ICollection<EmployeeServiceModel> Employees { get; set; } = new List<EmployeeServiceModel>();
    }
}
