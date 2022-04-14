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
    private readonly IDepartmentService _departmentService;

    public EmployeeController(
        IOrganizationService organizationService,
        IUserService userService,
        IEmployeeService employeeService,
        IValidationService validationService,
        IDepartmentService departmentService)
    {
        _organizationService = organizationService;
        _userService = userService;
        _employeeService = employeeService;
        _validationService = validationService;
        _departmentService = departmentService;
    }

    [Authorize]
    public IActionResult Add(string departmentId, string organizationId)
    {
        var employeeModel = new EmployeeFormModelRegister();

        if (departmentId == null)
        {
            var departments = _departmentService.GetAllDepartments(organizationId);

        

           return View();
        }

        var userId = User.GetId();

        var isAuthorized = _userService.IsAdminAuthorized(userId, organizationId);

        var organizationName = _organizationService.GetOrganizationNameById(organizationId);

        if (!isAuthorized)
        {
            return Unauthorized();
        }

        employeeModel = new EmployeeFormModelRegister()
        {
            OrganizationName = organizationName
        };

        return View(employeeModel);
    }


    [HttpPost]
    [Authorize]
    public IActionResult Add(string departmentId, string organizationId, EmployeeFormModelRegister employee)
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

    [Authorize]
    public IActionResult Register()
    {




        return View();

    }

    [Authorize]
    [HttpPost]
    public IActionResult Register(EmployeeFormModelRegister employee)
    {




        return View();

    }

}