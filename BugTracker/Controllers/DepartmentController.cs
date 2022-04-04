using BugTracker.Infrastructure;
using BugTracker.Models.ServiceModels.Department;
using BugTracker.Models.ViewModels.Organization;

namespace BugTracker.Controllers
{
    using Core.Contracts;
    using Models.ViewModels.Department;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IOrganizationService _organizationService;
        private readonly IUserService _userService;

        public DepartmentController(IDepartmentService departmentService, IUserService userService, IOrganizationService organizationService)
        {
            this._departmentService = departmentService;
            this._organizationService = organizationService;
            this._userService = userService;
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
            var organizationId = GetOrganizationId();

            department.OrganizationId = organizationId;

            var result = this._departmentService.ValidateDepartment(department);

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

            var save = this._departmentService.Save(department);

            if (save == false)
            {
                return View(department);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult All()
        {
            var organizationId = this.GetOrganizationId();

            var departmentsList =

                this._departmentService.GetAllDepartments(organizationId);

            return View(departmentsList);
        }

        public IActionResult Department(string departmentId)
        {
            var department = _departmentService.GetDepartment(departmentId);

            return View(department);
        }

        private string GetOrganizationId()
        {
            var userId = this.User.GetId();

            var organizationModel = this._organizationService.GetOrganizationByAdminId(_userService.GetAdminId(userId));
            return organizationModel.Id;
        }
    }
}
