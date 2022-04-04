using Microsoft.AspNetCore.Authorization;

namespace BugTracker.Controllers;

using Core.Contracts;
using Models.ViewModels.Bug;
using Microsoft.AspNetCore.Mvc;

public class BugController : Controller
{
    private readonly IBugService _service;
    private readonly IValidationService _validationService;
    public BugController(
        IBugService service,
        IValidationService validationService)
    {
        this._service = service;
        this._validationService = validationService;
    }
    [Authorize]
    public IActionResult Add()
    {


        return View(new AddBugFormModel()
        {
            Priorities = this._service.GetPriorities(),
            StatusList = this._service.GetStatus()
        });

    }

    [Authorize]
    [HttpPost]
    public IActionResult Add(AddBugFormModel bug)
    {
        var result = this._service.ValidateBug(bug);

        if (result.Count > 0)
        {
            foreach (var kvp in result)
            {
                ModelState.AddModelError(kvp.Key, kvp.Value);
            }
        }

        if (ModelState.IsValid == false)
        {
            bug.Priorities = this._service.GetPriorities();
            bug.StatusList = this._service.GetStatus();
            return View(bug);
        }

        var save = _service.Save(bug);

        if (save == false)
        {
            //TODO: add error message if could not successfully save the entity
            return View(bug);
        }


        return RedirectToAction("Index", "Home");
    }

    [Authorize] 
    public IActionResult All()
    {
        return View();
    }

}