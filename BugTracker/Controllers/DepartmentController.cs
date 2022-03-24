namespace BugTracker.Controllers
{
    using Core.Contracts;
    using Models.ViewModels.Department;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;


    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            this._service = service;
        }

        [Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddDepartmentFormModel department)
        {
            var result = this._service.ValidateDepartment(department);

            if (result.Count > 0)
            {
                foreach (var kvp in result)
                {
                    ModelState.AddModelError(kvp.Key, kvp.Value);
                }
            }

            if (ModelState.IsValid == false)
            {
                return View(department);
            }

            var save = this._service.Save(department);

            if (save==false)
            {
               return View(department);
            }

            return RedirectToAction("Index", "Home");

        }
    }
}
