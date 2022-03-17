using BugTracker.Core.Contracts;
using BugTracker.Models.ViewModels.Organization;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class OrganizationController:Controller
    {
        private readonly IOrganizationService _service;

        public OrganizationController(IOrganizationService service)
        {
            this._service = service;
        }

        public IActionResult Add()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Add(AddOrganizationFormModel organization)
        {
            var result = this._service.ValidateOrganization(organization);

            return RedirectToAction("Index", "Home");
        }
    }
}
