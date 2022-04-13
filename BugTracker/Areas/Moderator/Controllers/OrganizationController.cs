namespace BugTracker.Areas.Moderator.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class OrganizationController : ModeratorController
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
