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
            var organizations =
                _repo.All<Organization>().FirstOrDefault(o => o.Name == organization.Name);


            var result = new Dictionary<string, string>();

            var exists = this._repo.All<Organization>().Any(o => o.Name == organization.Name);

            if (exists)
            {
                result.Add(nameof(organization.Name),InvalidOrganizationName);
            }

            return result;
        }

        public string AddEntity(AddOrganizationFormModel organization)
        {
            var organizationId = string.Empty;

            Organization organizationData = new Organization()
            {
                Name = organization.Name,
                Country = organization.Country,
                StreetName = organization.StreetName,
                StreetNumber = organization.StreetNumber,
                TownName = organization.TownName

            };

            try
            {
                this._repo.Add(organizationData);
                this._repo.SaveChanges();
                organizationId = organizationData.Id;
            }
            catch (Exception)
            {
                organizationId = null;
            }

            return organizationId;
        }
    }
}
