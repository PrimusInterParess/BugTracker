namespace BugTracker.Core.Contracts
{
    public interface IUserService
    {
        bool IsUserAdministrator(string user);

    }
}
