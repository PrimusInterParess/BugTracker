namespace BugTracker.Core.Services
{
    using Infrastructure.Data;
    using System.Globalization;
    using Models.Constants;
    using Contracts;

    public class ValidationService : IValidationService
    {
        private readonly BugTrackerDbContext _data;


        public ValidationService(
            BugTrackerDbContext data)
        {
            this._data = data;
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
            => this._data.Organizations.Any(o => o.Name == organizationName);

        public bool OrganizationId(string organizationId)
            => this._data.Organizations.Any(o => o.Id == organizationId);

        public bool DepartmentOrganization(string departmentId, string organizationId)
            => this._data.Departments.Any(d => d.Id == departmentId && d.OrganizationId == organizationId);

        public bool DepartmentId(string departmentId)
            => _data.Departments.Any(d => d.Id == departmentId);

        public bool ProjectNameExists(string name, string departmentId)
            => _data.Departments.Where(d => d.Id == departmentId).Any(d => d.Projects.Any(p => p.Name == name));
    }

}
