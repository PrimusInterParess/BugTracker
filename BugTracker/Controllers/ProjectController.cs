using BugTracker.Models.ViewModels.Priority;
using BugTracker.Models.ViewModels.Project;
using Microsoft.AspNetCore.Authorization;

namespace BugTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ProjectController:Controller
    {
        [Authorize]
        public IActionResult Add(string departmentId)
        {
            
            return View(new AddProjectFormModel()
            {
                DepartmentId = departmentId
            });

        }

        [HttpPost]
        public IActionResult Add(AddProjectFormModel project)
        {
            return RedirectToAction("Index", "Home");

        }

        public IActionResult All(string organizationId)
        {
            return View();
        }
    }
}
