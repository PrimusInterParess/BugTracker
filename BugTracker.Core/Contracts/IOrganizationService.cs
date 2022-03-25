using System.Security.Claims;

namespace BugTracker.Core.Contracts;

using Models.ViewModels.Organization;

public interface IOrganizationService
{
    Dictionary<string, string> ValidateOrganization(AddOrganizationFormModel organization);

    string Save(AddOrganizationFormModel organization,string UserId);

    string GetAdminId(ClaimsPrincipal user);
}