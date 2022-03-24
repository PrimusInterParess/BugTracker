using System.ComponentModel;
using BugTracker.Models.ViewModels.Administrator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BugTracker.Controllers
{
    public class AdministratorController:Controller
    {
        [DisplayName ("Register as admin")]
        [Authorize]
        public IActionResult RegisterAsAdmin()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult RegisterAsAdmin(RegisterAdminFormModel admin)
        {


            return View(admin);
        }
    }
}
