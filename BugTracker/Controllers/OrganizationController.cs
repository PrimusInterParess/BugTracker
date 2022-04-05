namespace BugTracker.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Models.ViewModels.Organization;
    using Microsoft.AspNetCore.Mvc;
    using Models.ServiceModels.Organization;
    using BugTracker.Infrastructure.Data.Models;
    using Core.Contracts;
    using Infrastructure;
    using static Models.Constants.MessageConstants;

    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _service;
        private readonly IUserService _userService;
      
        public OrganizationController(
            IOrganizationService service,
             IUserService userService)
        {
            _service = service;
            _userService = userService;
        }

        [Authorize]
        public IActionResult Add()
        {

            if (IsAdmin())
            {
                return View();
            }

            return RedirectToAction("Register", "Administrator");

        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(AddOrganizationFormModel organization)
        {
            var userId = User.GetId();


            if (!IsAdmin())
            {
                return RedirectToAction("Register", "Administrator");

            }

            var alreadyExists = this._service.CheckIfOrganizationExistsByName(organization.Name);

            if (alreadyExists)
            {
                ModelState.AddModelError(String.Empty, InvalidData);
            }


            if (ModelState.IsValid == false)
            {
                return View(organization);
            }

            var organizationId = this._service.Save(organization, userId);

            if (organizationId == null)
            {
                ModelState.AddModelError(String.Empty, InvalidAttempt);

                return View(organization);
            }

            return RedirectToAction("MyOrganization", nameof(Organization));



        }

        [Authorize]
        public IActionResult Edit(string organizationId)
        {
            var organization = _service.GetOrganizationById(organizationId);

            return View(organization);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(OrganizationServiceEditModel organization)
        {

            return View();
        }


        [Authorize]
        public IActionResult MyOrganization()
        {

            if (!IsAdmin())
            {
                return RedirectToAction("Register", "Administrator");
            }

            var userId = User.GetId();

            var organization = _service.GetOrganizationByUserId(userId);

            return View(organization);
        }

        private bool IsAdmin()
        {
            var userId = User.GetId();
            
            return _userService.IsUserAdministrator(userId);

        }
}

}
