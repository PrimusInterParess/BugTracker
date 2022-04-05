using BugTracker.Infrastructure.Models;
using BugTracker.Models.ViewModels.Administrator;

namespace BugTracker.Core.Services
{
    using BugTracker.Core.Contracts;
    using BugTracker.Infrastructure.Data;

    public class AdministratorService:IAdministratorService
    {
        private readonly BugTrackerDbContext _repo;

        public AdministratorService(BugTrackerDbContext repo)
        {
            _repo = repo;
        }
       
        public bool Register(RegisterAdminFormModel admin,string userId)
        {
            var administratorData = new Administrator()
            {
                Email = admin.Email,
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                PhoneNumber = admin.PhoneNumber,
                UserId = userId

            };

            try
            {
                _repo.Administrators.Add(administratorData);
                _repo.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
