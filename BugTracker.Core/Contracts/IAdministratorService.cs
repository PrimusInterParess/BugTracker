using BugTracker.Models.ViewModels.Administrator;

namespace BugTracker.Core.Contracts;

public interface IAdministratorService
{
    bool AlreadyExists(string adminId);

    bool Register(RegisterAdminFormModel admin,string userId);
}