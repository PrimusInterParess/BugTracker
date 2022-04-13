namespace BugTracker.Areas.Moderator.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Area(ModeratorConstants.AreaName)]
    [Authorize(Roles = ModeratorConstants.ModeratorRoleName)]
    public abstract class ModeratorController:Controller
    {
    }
}
