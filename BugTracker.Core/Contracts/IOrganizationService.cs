using System.Security.Claims;
using BugTracker.Models.ServiceModels;
using BugTracker.Models.ViewModels.Organization;

namespace BugTracker.Core.Contracts;

using Models.ViewModels.Organization;

public interface IOrganizationService
{
    Dictionary<string, string> ValidateOrganization(AddOrganizationFormModel organization);

    string Save(AddOrganizationFormModel organization,string UserId);

    OrganizationVIewModel GetOrganization(string adminId);
}