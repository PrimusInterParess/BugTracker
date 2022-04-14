
namespace BugTracker.Models.ServiceModels.Project
{
    public class ProjectsListModel
    {
        public string DepartmentId { get; set; }

        public string OrganizatioId { get; set; }

        public List<ProjectServiceModel> Projects { get; set; } 
    }
}
