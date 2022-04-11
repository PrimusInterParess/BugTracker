using BugTracker.Infrastructure.Data.Models;

namespace BugTracker.Controllers;

using BugTracker.Core.Contracts;
using BugTracker.Infrastructure;
using BugTracker.Models.ServiceModels.Employee;
using BugTracker.Models.ViewModels.Employee;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using static BugTracker.WebConstants.DisplayNames;
using static BugTracker.Models.Constants.MessageConstants;


public class EmployeeController : Controller
{
    private readonly IOrganizationService _organizationService;
    private readonly IUserService _userService;
    private readonly IEmployeeService _employeeService;
    private readonly IValidationService _validationService;

    public EmployeeController(
        IOrganizationService organizationService,
        IUserService userService,
        IEmployeeService employeeService,
        IValidationService validationService)
    {
        _organizationService = organizationService;
        _userService = userService;
        _employeeService = employeeService;
        _validationService = validationService;
    }

    [Authorize]
    public IActionResult Add(string departmentId, string organizationId)
    {
        var userId = this.User.GetId();

        var isAuthorized = this._userService.IsAdminAuthorized(userId, organizationId);

        if (!isAuthorized)
        {
            return Unauthorized();
        }

        return View();
    }


    [HttpPost]
    [Authorize]
    public IActionResult Add(string departmentId, string organizationId, AddEmployeeFormModel employee)
    {
        if (!_validationService.OrganizationId(organizationId) || !_validationService.DepartmentOrganization(departmentId, organizationId))
        {
            //TODO Return proper error
        }

        var saved = _employeeService.Save(employee.Name, employee.Email, organizationId, departmentId);

        if (!saved)
        {
            //TODO Return proper error
        }

        return RedirectToAction(nameof(EmployeeController.ByDepartment), nameof(Employee), new { departmentId = departmentId, organizationId = organizationId });
    }


    [Authorize]
    [DisplayName(EmployeesByDepartment)]
    public IActionResult ByDepartment(
        string departmentId,
        string organizationId)
    {
        var userId = User.GetId();

        if (!_userService.IsAdminAuthorized(userId, organizationId))
        {
            return Unauthorized();
        }

        var employeeModel = new EmployeesDepartmentServiceModel()
        {
            OrganizationId = organizationId,
            DeparmtnetId = departmentId,
            Employees = _employeeService.GetEmployeesByDepartmentId(departmentId)
        };



        return View(employeeModel);
    }

}