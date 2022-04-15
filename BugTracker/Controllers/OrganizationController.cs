using BugTracker.Models.ServiceModels.Organization;

namespace BugTracker.Controllers
{
    using BugTracker.Infrastructure.Data.Models;
    using BugTracker.Infrastructure.Models;
    using Core.Contracts;
    using Infrastructure;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels.Organization;
    using System.ComponentModel;
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

            if (_userService.IsUserAdministrator(userId))
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

            if (!_userService.IsUserAdministrator(userId))
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

            return RedirectToAction(nameof(OrganizationController.Information),
                nameof(Organization),
                new { organizationId = organizationId });

        }


        [Authorize]
        public IActionResult Edit(string organizationId)
        {
            var userId = User.GetId();

            if (!_userService.IsAdminAuthorized(userId, organizationId))
            {
                return BadRequest();

            }

            var organization = _organizationService.GetOrganizationById(organizationId);

            return View(new OrganizationFormModel()
            {
                Country = organization.Country,
                LogoUrl = organization.LogoUrl,
                Name = organization.Name,
                StreetName = organization.TownName,
                StreetNumber = organization.StreetNumber,
                TownName = organization.TownName
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(string organizationId, OrganizationFormModel organization)
        {
            var userId = User.GetId();

            if (!_userService.IsAdminAuthorized(userId, organizationId))
            {
                return BadRequest();
            }

            var edited = _organizationService.Edit(
                organizationId,
                organization.Name,
                organization.Country,
                organization.TownName,
                organization.StreetName,
                organization.StreetNumber,
                organization.LogoUrl);


            return RedirectToAction(nameof(OrganizationController.Information), nameof(Organization),
                new { organizationId = organizationId });


        }

        [Authorize]
        public IActionResult Remove()
        {
            var userId = User.GetId();

            var isUserAdmin = _userService.IsUserAdministrator(userId);

            if (!isUserAdmin)
            {
                return BadRequest();
            }

            var organizations = _organizationService.GetAllOrganizationsByUser(userId);


            return View(organizations);

        }

        [Authorize]
        public IActionResult Delete(string organizationId)
        {
            var userId = User.GetId();

            var isUserAdmin = _userService.IsUserAdministrator(userId);

            if (!isUserAdmin)
            {
                return BadRequest();
            }

            var deleted = _organizationService.Delete(organizationId);

            var allOrganizations = _organizationService.GetAllOrganizationsByUser(userId);

            return RedirectToAction("Index");

        }


        [Authorize]
        public IActionResult Information(string organizationId)
        {
            var userId = User.GetId();

            if (!IsAuthorized(userId, organizationId))
            {
                return RedirectToAction("Register", "Administrator");
            }

            var organization = _organizationService.GetOrganizationById(organizationId);

            return View(organization);
        }


        [Authorize]
        [DisplayName("All Organizations")]
        public IActionResult All()
        {
            var userId = User.GetId();

            if (!_userService.IsUserAdministrator(userId))
            {
                return RedirectToAction(nameof(AdministratorController.Register), "Administrator");
            }

            var organizations = _organizationService.GetAllOrganizationsByUser(userId);

            return View(organizations);
        }

        private bool IsAuthorized(string userId, string organizationId) =>
            _userService.IsAdminAuthorized(userId, organizationId);

    }
}


