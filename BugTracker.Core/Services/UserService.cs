namespace BugTracker.Core.Services
{
    using Contracts;
    using BugTracker.Infrastructure.Data;

    public class UserService : IUserService
    {
        private readonly BugTrackerDbContext _data;

        public UserService(BugTrackerDbContext data) => this._data = data;

        public bool IsUserAdministrator(string userId)
            => this._data
                .Administrators
                .Any(u => u.UserId == userId);

        public bool IsUserEmployee(string userId)
            => this._data.Employees
                .Any(e => e.UserId == userId);

        public bool IsAdminAuthorized(string userId, string organizationId)
            => _data.Administrators.Any(
                a => a.UserId == userId && a.Organizations.Any(o => o.Id == organizationId));

      
    }
}
