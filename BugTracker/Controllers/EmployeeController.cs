using BugTracker.Core.Contracts;
using BugTracker.Infrastructure;
using BugTracker.Infrastructure.Models;
using BugTracker.Models.ViewModels.Employee;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BugTracker.Models.Constants.MessageConstants;
namespace BugTracker.Controllers;

public class EmployeeController : Controller
{
    private readonly IOrganizationService _organizationService;
    private readonly IUserService _userService;
    public EmployeeController(IOrganizationService organizationService, IUserService userService)
    {
        this._organizationService = organizationService;
        this._userService = userService;
    }

    [Authorize]
    public IActionResult Add()
    {
        var userId = this.User.GetId();

        var adminId = this._userService.IsUserAdministrator(userId);

        if (adminId)
        {
           
            return RedirectToAction("Register","Administrator");
        }

        return View();
    }


    [HttpPost]
    [Authorize]
    public IActionResult Add(AddEmployeeFormModel employee)
    {

        return View();
    }

}