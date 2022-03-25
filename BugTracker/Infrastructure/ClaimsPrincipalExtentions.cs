using System.Security.Claims;

namespace BugTracker.Infrastructure
{
    public static  class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal user) => user.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
