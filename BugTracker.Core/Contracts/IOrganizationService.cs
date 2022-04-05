using System.Security.Claims;
using BugTracker.Models.ServiceModels;
using BugTracker.Models.ServiceModels.Organization;
using BugTracker.Models.ViewModels.Organization;

namespace BugTracker.Core.Contracts;

using Models.ViewModels.Organization;

public interface IOrganizationService
{
   bool CheckIfOrganizationExistsByName(string organizationName);

    string Save(AddOrganizationFormModel organization,string userId);

    OrganizationServiceModel GetOrganizationByUserId(string userId);

    OrganizationServiceEditModel GetOrganizationById(string organizationId);

    string GetOrganizationIdByUserId(string userId);
}