using System.Reflection.Metadata;
using BugTracker.Infrastructure.Data.Models;

namespace BugTracker.Core.Services
{
    using Contracts;
    using Models.ViewModels.Organization;
    using static BugTracker.Models.Constants.MessageConstants;
    public class OrganizationService:IOrganizationService
    {
        private readonly IRepository _repo;

        public OrganizationService(IRepository repo)
        {
            this._repo=repo;
        }

        public Dictionary<string, string> ValidateOrganization(AddOrganizationFormModel organization)
        {
            var result = new Dictionary<string, string>();

            var exists = this._repo.All<Organization>().Any(o => o.Name == organization.Name);

            if (exists)
            {
                result.Add(nameof(organization.Name),InvalidOrganizationName);
            }

            return result;
        }
    }
}
