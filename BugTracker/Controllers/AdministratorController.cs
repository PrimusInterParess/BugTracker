namespace BugTracker.Controllers
{
    using System.ComponentModel;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels.Administrator;
    using Core.Contracts;
    using Infrastructure;

    using static Models.Constants.MessageConstants;

    public class AdministratorController:Controller
    {
        private readonly IAdministratorService _service;
        public AdministratorController(IAdministratorService service)
        {
            _service = service;
        }

        [DisplayName ("Register as admin")]
        [Authorize]
        public IActionResult Register()
        {
            var userId = this.User.GetId();

            var alreadyExists = _service.AlreadyExists(userId);

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
            var userId = this.User.GetId();

            var alreadyExists = _service.AlreadyExists(userId);

            if (ModelState.IsValid == false)
            {
                return View(admin);
            }

            if (alreadyExists)
            {
                ModelState.AddModelError(String.Empty, InvalidAttempt);

                return View(admin);
            }

            var registered = _service.Register(admin, userId);

            return RedirectToAction("Index", "Home");
        }
    }
}
