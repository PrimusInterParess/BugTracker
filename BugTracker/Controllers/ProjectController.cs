using BugTracker.Core.Contracts;
using BugTracker.Infrastructure;
using BugTracker.Infrastructure.Data.Models;
using BugTracker.Models.ServiceModels.Project;
using BugTracker.Models.ViewModels.Priority;
using BugTracker.Models.ViewModels.Project;
using Microsoft.AspNetCore.Authorization;
using static BugTracker.Models.Constants.MessageConstants;

namespace BugTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ProjectController : Controller
    {
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly IDepartmentService _departmentService;
        private readonly IValidationService _validationService;

        public ProjectController(
            IUserService userService,
            IProjectService projectService,
            IDepartmentService departmentService, IValidationService validationService)
        {
            _userService = userService;
            _projectService = projectService;
            _departmentService = departmentService;
            _validationService = validationService;
        }

        [Authorize]
        public IActionResult Add(string organizationId, string departmentId)
        {
            var userId = User.GetId();

            if (!_userService.IsAdminAuthorized(userId, organizationId))
            {
                return Unauthorized();
            }

            if (!_validationService.DepartmentId(departmentId))
            {
                return BadRequest();
            }

            if (!_validationService.DepartmentOrganization(departmentId, organizationId))
            {
                return BadRequest();
            }

            return View();

        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(string organizationId, string departmentId, AddProjectFormModel project)
        {
            var userId = User.GetId();

            if (!_userService.IsAdminAuthorized(userId, organizationId))
            {
                return Unauthorized();
            }

            if (!_validationService.DepartmentId(departmentId))
            {
                return BadRequest();
            }

            if (!_validationService.DepartmentOrganization(departmentId, organizationId))
            {
                return BadRequest();
            }

            var projectId = this._projectService.Save(project.Name,project.Description,project.Created,project.DueDate,departmentId,organizationId);

            if (projectId == null)
            {
                ModelState.AddModelError(String.Empty, InvalidAttempt);

                return View(project);
            }

            return RedirectToAction(nameof(ProjectController.Information),
               nameof(Project),
               new { projectId = projectId });

        }

        [Authorize]
        public IActionResult Information(string projectId)
        {
            return View();
        }

        [Authorize]
        public IActionResult All(string organizationId, string departmentId)
        {
            var userId = User.GetId();

            if (!_userService.IsAdminAuthorized(userId, organizationId))
            {
                return BadRequest();
            }

            var allProjects = _projectService.All(departmentId);

            var projectsData = new ProjectsListModel()
            {
                OrganizatioId = organizationId,
                DepartmentId = departmentId,
                Projects = allProjects
            };

            return View(projectsData);
        }
    }
}
