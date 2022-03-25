namespace BugTracker.Core.Services
{
    using System.Security.Claims;
    using Infrastructure.Data;
    using BugTracker.Infrastructure.Data.Models;
    using Contracts;
    using Models.ViewModels.Organization;

    using static Models.Constants.MessageConstants;

    public class OrganizationService : IOrganizationService
    {
        private readonly BugTrackerDbContext _repo;

        public OrganizationService(BugTrackerDbContext repo)
        {
            this._repo = repo;
        }

        public Dictionary<string, string> ValidateOrganization(AddOrganizationFormModel organization)
        {
            var organizations =
                _repo.Organizations.FirstOrDefault(o => o.Name == organization.Name);


            var result = new Dictionary<string, string>();

            var exists = this._repo.Organizations.Any(o => o.Name == organization.Name);

            if (exists)
            {
                result.Add(nameof(organization.Name), InvalidOrganizationName);
            }

            return result;
        }

        public string GetAdminId(ClaimsPrincipal user)
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);

            var adminId = this._repo.Administrators.Where(a => a.UserId == userId).Select(a=>a.Id);


            return adminId;
        }

        public string Save(AddOrganizationFormModel organization, string userId)
        {
            var organizationId = string.Empty;

            Organization organizationData = new Organization()
            {
                Name = organization.Name,
                Country = organization.Country,
                StreetName = organization.StreetName,
                StreetNumber = organization.StreetNumber,
                TownName = organization.TownName,
                AdministratiorId = userId
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
