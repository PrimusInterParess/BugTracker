using BugTracker.Infrastructure.Data;

namespace BugTracker.Core.Services
{
    using System;
    using System.Security.Claims;
    using Contracts;

    public class UserService:IUserService
    {
        private readonly BugTrackerDbContext _repo;

        public UserService(BugTrackerDbContext repo)
        {
            this._repo = repo;
        }

        public string GetAdminId(ClaimsPrincipal user)
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);

            var admin = this._repo
                .Administrators
                .FirstOrDefault(a => a.UserId == userId);

            return admin.Id;
        }

        public string GetUserId(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
