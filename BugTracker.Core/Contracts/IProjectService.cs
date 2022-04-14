namespace BugTracker.Core.Contracts
{
    using BugTracker.Models.ServiceModels.Project;

    public interface IProjectService
    {
        List<ProjectServiceModel> All(string departmentId);
        string Save(string projectName, string projectDescription, DateTime projectCreated, DateTime projectDueDate, string departmentId, string organizationId);
    }
}
