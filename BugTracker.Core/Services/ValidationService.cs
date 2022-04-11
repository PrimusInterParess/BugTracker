namespace BugTracker.Core.Services
{
    using Infrastructure.Data;
    using System.Globalization;
    using Models.Constants;
    using Contracts;

    public class ValidationService : IValidationService
    {
        private readonly BugTrackerDbContext _repo;


        public ValidationService(
            BugTrackerDbContext repo)
        {
            this._repo = repo;
        }

        public (bool, DateTime) ValidateDate(string model)
        {
            DateTime date;

            var isValid = DateTime.TryParseExact(
                model,
                FormatingConstants.NormalDateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date);

            return (isValid, date);
        }

        public bool AreDatesValid(DateTime appearedOn, DateTime dueDate)
        {
            var currentDate = DateTime.Now;

            if (appearedOn >= dueDate ||
                appearedOn > currentDate)
            {
                return false;
            }

            return true;
        }

        public bool OrganizationName(string organizationName)
            => this._repo.Organizations.Any(o => o.Name == organizationName);

        public bool OrganizationId(string organizationId)
            => this._repo.Organizations.Any(o => o.Id == organizationId);

        public bool DepartmentOrganization(string departmentId, string organizationId)
            => this._repo.Departments.Any(d => d.OrganizationId == organizationId);
    }

}
