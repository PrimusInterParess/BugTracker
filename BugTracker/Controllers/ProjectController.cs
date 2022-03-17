using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class ProjectController:Controller
    {
        public IActionResult Add()
        {
            return View();

        }

        //[HttpPost]
        //public IActionResult Add()
        //{
        //}
    }
}
