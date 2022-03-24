namespace BugTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;

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
