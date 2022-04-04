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

        public string? GetAdminId(string userId)
        {
           var admin = this._repo
                .Administrators.
                Where(a => a.UserId == userId).
                Select(a=>a.Id)
                .FirstOrDefault();

            return admin;
        }

        public string GetUserId(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
