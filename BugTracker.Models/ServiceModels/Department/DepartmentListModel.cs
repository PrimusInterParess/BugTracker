
namespace BugTracker.Models.ServiceModels.Department
{
    public class DepartmentListModel
    {
        public string OrganizationId { get; set; }

        public List<DepartmentServiceModel> Departments { get; set; } = new List<DepartmentServiceModel>();
    }
}
