using BugTracker.Models.ServiceModels.Employee;
using BugTracker.Models.ServiceModels.Project;

namespace BugTracker.Models.ViewModels.Department;

public class DepartmentViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }

    public string DepartmentSubject { get; set; }

    public ICollection<ProjectServiceModel> Projects { get; set; } = new HashSet<ProjectServiceModel>();

    public ICollection<EmployeeServiceModel> DepartmentEmployees { get; set; } = new HashSet<EmployeeServiceModel>();
}