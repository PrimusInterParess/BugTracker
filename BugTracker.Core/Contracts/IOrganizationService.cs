using System.Security.Claims;
using BugTracker.Models.ServiceModels;
using BugTracker.Models.ServiceModels.Organization;

namespace BugTracker.Core.Contracts;

using Models.ViewModels.Organization;

public interface IOrganizationService
{
    Dictionary<string, string> ValidateOrganization(AddOrganizationFormModel organization);

    string Save(AddOrganizationFormModel organization,string UserId);

    OrganizationServiceModel GetOrganization(string adminId);
}