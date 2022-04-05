namespace BugTracker.Core.Services
{
    using Contracts;
    using BugTracker.Infrastructure.Data;

    public class UserService : IUserService
    {
        private readonly BugTrackerDbContext _repo;

        public UserService(BugTrackerDbContext repo) => this._repo = repo;

        public bool IsUserAdministrator(string userId)
            => this._repo
                .Administrators
                .Any(u => u.UserId == userId);

    }
}
