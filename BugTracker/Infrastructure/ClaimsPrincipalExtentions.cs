using System.Security.Claims;

namespace BugTracker.Infrastructure
{
    public static  class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal user) => user.FindFirst(ClaimTypes.NameIdentifier).Value;

        public static bool IsModerator(this ClaimsPrincipal user) =>
            user.IsInRole(WebConstants.Roles.ModeratorRoleName);
    }
}
