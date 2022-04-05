namespace BugTracker.Controllers
{
    using System.ComponentModel;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels.Administrator;
    using Core.Contracts;
    using Infrastructure;
 
    using static Models.Constants.MessageConstants;
    
    public class AdministratorController : Controller
    {
        private readonly IAdministratorService _adminService;
        private readonly IUserService _userService;
                                
        public AdministratorController(IAdministratorService adminService, IUserService userService)
        {
            _adminService = adminService;
            _userService = userService;

        }

        [DisplayName("Register as admin")]
        [Authorize]
        public IActionResult Register()
        {

            var userId = User.GetId();


            var alreadyExists = _userService.IsUserAdministrator(userId);

            if (alreadyExists)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Register(RegisterAdminFormModel admin)
        {
            var userId = User.GetId();


            var alreadyExists = _userService.IsUserAdministrator(userId);

            if (ModelState.IsValid == false)
            {
                return View(admin);
            }

            if (alreadyExists)
            {
                ModelState.AddModelError(String.Empty, InvalidAttempt);

                return View(admin);
            }

            var registered = _adminService.Register(admin, userId);

            return RedirectToAction("Index", "Home");
        }
    }
}
