using BugTracker.Infrastructure;
using BugTracker.Models.ServiceModels.Organization;

namespace BugTracker.Controllers
{
    using BugTracker.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Core.Contracts;
    using Models.ViewModels.Organization;
    using Microsoft.AspNetCore.Mvc;

    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _service;
        private readonly IValidationService _ValidationService;
        private readonly IUserService _userService;

        public OrganizationController(
            IOrganizationService service,
            IValidationService validationService,
            IUserService userService)
        {
            this._ValidationService = validationService;
            this._service = service;
            this._userService = userService;

        }

        [Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(AddOrganizationFormModel organization)
        {
            var result = this._service.ValidateOrganization(organization);

            var adminId = this._userService.GetAdminId(null);

            var isSuccessfully = string.Empty;

            if (result.Count > 0)
            {
                foreach (var kvp in result)
                {
                    ModelState.AddModelError(kvp.Key, kvp.Value);
                }
            }

            if (ModelState.IsValid == false)
            {
                return View(organization);
            }
            else
            {
                isSuccessfully = this._service.Save(organization, adminId);

                if (isSuccessfully == null)
                {
                    ModelState.AddModelError("Invalid", "operation");

                    return View(organization);
                }

                return RedirectToAction("MyOrganization", nameof(Organization));
            }


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
            var userId = this.User.GetId();

            var adminId = this._userService.GetAdminId(userId);

            var organization = _service.GetOrganizationByAdminId(adminId);

            return View(organization);
        }
    }
}
