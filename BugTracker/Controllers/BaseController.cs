using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    [Authorize]
    public class BaseController:Controller
    {
    }
}
