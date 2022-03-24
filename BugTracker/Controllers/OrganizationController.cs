using BugTracker.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace BugTracker.Controllers
{
    using Core.Contracts;
    using Models.ViewModels.Organization;
    using Microsoft.AspNetCore.Mvc;

    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _service;
        private readonly IValidationService _ValidationService;

        public OrganizationController(IOrganizationService service,IValidationService validationService)
        {
            this._ValidationService = validationService;
            this._service = service;
        }

        [Authorize]
        public IActionResult Add()
        {
            var isAdmin = _ValidationService.IsAdmin(this.User);

            if (isAdmin)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");

        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(AddOrganizationFormModel organization)
        {

           

          
            
                var result = this._service.ValidateOrganization(organization);

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
                    isSuccessfully = this._service.AddEntity(organization);

                    if (isSuccessfully == null)
                    {
                        ModelState.AddModelError("Invalid", "operation");

                        return View(organization);
                    }

                    return RedirectToAction("Info", nameof(Organization));
                }
                
                
        }

        //[Authorize]
        //public IActionResult Info()
        //{

        //}
    }
}
