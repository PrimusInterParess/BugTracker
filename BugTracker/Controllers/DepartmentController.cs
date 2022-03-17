using BugTracker.Models.ViewModels.Department;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class DepartmentController:Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddDepartmentFormModel department)
        {


            return View(department);
        }
    }
}
