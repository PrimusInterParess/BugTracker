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
    public IActionResult Add()
    {
        return View(new AddBugFormModel()
        {
            Priorities = this._service.GetPriorities(),
            StatusList = this._service.GetStatus()
        });

    }

    [HttpPost]
    public IActionResult Add(AddBugFormModel bug)
    {
        var result = this._service.ValidateBug(bug);

        if (result.Count > 0)
        {
            foreach (var kvp in result)
            {
                ModelState.AddModelError(kvp.Key,kvp.Value);
            }
        }

        if (ModelState.IsValid == false)
        {
            bug.Priorities = this._service.GetPriorities();
            bug.StatusList = this._service.GetStatus();
            return View(bug);
        }


        return RedirectToAction("Index", "Home");
    }

    public IActionResult All()
    {

    }

}