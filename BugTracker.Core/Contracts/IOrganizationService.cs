using BugTracker.Models.ViewModels.Organization;

namespace BugTracker.Core.Contracts;

public interface IOrganizationService
{
    Dictionary<string, string> ValidateOrganization(AddOrganizationFormModel organization);
}