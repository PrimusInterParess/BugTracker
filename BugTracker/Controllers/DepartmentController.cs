namespace BugTracker.Controllers
{
    using Core.Contracts;
    using Models.ViewModels.Department;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using Infrastructure;
    using Models.ServiceModels.Department;
    using Models.ViewModels.Organization;

    using static Models.Constants.MessageConstants;

    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IOrganizationService _organizationService;
        private readonly IUserService _userService;
     

        public DepartmentController(
            IDepartmentService departmentService,
            IUserService userService,
            IOrganizationService organizationService)
        {
            _departmentService = departmentService;
            _organizationService = organizationService;
            _userService = userService;
           
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

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddDepartmentFormModel department)
        {
            var userId = User.GetId();
            var organizationId = GetOrganizationId(userId);

            if (!_userService.IsUserAdministrator(userId))
            {
                return RedirectToAction("Register", "Administrator");
            }

            department.OrganizationId = organizationId;

            var alreadyExists = this._departmentService.ValidateDepartmentName(department.Name, organizationId);

            if (alreadyExists)
            {
                ModelState.AddModelError(String.Empty, InvalidData);
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
        public IActionResult All(string organizationId)
        {

            return View();
        }

        public IActionResult Department(string departmentId)
        {
            var department = _departmentService.GetDepartment(departmentId);

            return View(department);
        }

        private string? GetOrganizationId(string userId)
        {

           if (_userService.IsUserAdministrator(userId))
            {
                return _organizationService.GetOrganizationIdByUserId(userId);
            }

            return null;
        }


    }

}
