using System.ComponentModel;
using BugTracker.Infrastructure.Models;

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
        private readonly IOrganizationService _organizationService;
        private readonly IUserService _userService;
        private readonly IValidationService _validationService;
        private readonly IAdministratorService _administratorService;

        public OrganizationController(
            IOrganizationService organizationService,
             IUserService userService,
            IValidationService validationService, IAdministratorService administratorService)
        {
            _organizationService = organizationService;
            _userService = userService;
            _validationService = validationService;
            _administratorService = administratorService;
        }

        [Authorize]
        public IActionResult Add()
        {
            var userId = User.GetId();

            if (IsAdmin(userId))
            {
                return View();
            }

            return RedirectToAction("Register", "Administrator");

        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(OrganizationFormModel organization)
        {
            var userId = User.GetId();

            if (!IsAdmin(userId))
            {
                return RedirectToAction(nameof(AdministratorController.Register), "Administrator");
            }

            var alreadyExists = _organizationService.AlreadyExists(organization.Name, userId);

            if (alreadyExists)
            {
                ModelState.AddModelError(String.Empty, InvalidAttempt);

                return View(organization);

            }

            var organizationId = _organizationService.Save(
                organization.Name,
                organization.Country,
                organization.TownName,
                organization.StreetName,
                organization.StreetNumber,
                organization.LogoUrl,
                userId);

            if (organizationId == null)
            {
                ModelState.AddModelError(String.Empty, InvalidAttempt);

                return View(organization);
            }

            return RedirectToAction(nameof(OrganizationController.Information), nameof(Organization), new { organizationId = organizationId });

        }

        [Authorize]
        [DisplayName("All Organizations")]
        public IActionResult AllOrganizations()
        {
            var userId = User.GetId();

            if (!IsAdmin(userId))
            {
                return RedirectToAction(nameof(AdministratorController.Register), "Administrator");
            }

            var organizations = _organizationService.GetAllOrganizationsByUser(userId);
            
            return View(organizations);
        }

        [Authorize]
        public IActionResult Edit(string organizationId)
        {
            var userId = User.GetId();

            if (IsAdmin(userId))
            {
                return RedirectToAction(nameof(AdministratorController.Register), nameof(Administrator));

            }

            var organization = _organizationService.GetOrganizationById(organizationId);

            return View(organization);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(string organizationId, OrganizationFormModel organization)
        {

            return View();
        }


        [Authorize]
        public IActionResult Information(string organizationId)
        {
            var userId = User.GetId();

            if (!IsAdmin(userId))
            {
                return RedirectToAction("Register", "Administrator");
            }

            var organization = _organizationService.GetOrganizationById(organizationId);

            return View(organization);
        }

        private bool IsAdmin(string userId) =>
       _userService.IsUserAdministrator(userId);

    }
}


