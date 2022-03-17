using BugTracker.Core.Contracts;
using BugTracker.Models.ViewModels.Organization;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class OrganizationController : Controller
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

            var isSuccessfully = true;

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
                isSuccessfully = this._service.AddEntity(organization);

                if (isSuccessfully==false)
                {
                    ModelState.AddModelError("Invalid","operation");

                    return View(organization);
                }
            }
            
            return RedirectToAction("Index", "Home");
        }
    }
}
