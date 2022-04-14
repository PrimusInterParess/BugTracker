
using BugTracker.Core.Contracts;
using BugTracker.Infrastructure.Data;
using BugTracker.Infrastructure.Data.Models;
using BugTracker.Models.ServiceModels.Project;

namespace BugTracker.Core.Services
{
    public class ProjectService:IProjectService
    {
        private readonly BugTrackerDbContext _data;
        private readonly IValidationService _validationService;

        public ProjectService(
            BugTrackerDbContext data, 
            IValidationService validationService)
        {
            _data = data;
            _validationService = validationService;
        }

        public List<ProjectServiceModel> All(string departmentId)
            => _data.Projects
                .Where(p => p.DepartmentId == departmentId)
                .Select(p => new ProjectServiceModel()
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();

        public string Save(
            string projectName, 
            string projectDescription, 
            DateTime projectCreated,
            DateTime projectDueDate,
            string departmentId, 
            string organizationId)
        {
            var exists = _validationService.ProjectNameExists(projectName, departmentId);

            if (exists)
            {
                return null;
            }

            var areValid = _validationService.AreDatesValid(projectCreated, projectDueDate);

            if (!areValid)
            {
                return null;
            }

            var projectId = string.Empty;

            var projectData = new Project()
            {
                Name = projectName,
                Description = projectDescription,
                Created = projectCreated,
                DueDate = projectDueDate,
                DepartmentId = departmentId,
                OrganizationId = organizationId
            };

            try
            {
                this._data.Add(projectData);
                this._data.SaveChanges();
                projectId = projectData.Id;
            }
            catch (Exception)
            {
                organizationId = null;
            }

            return projectId;

        }

       
    }
}
