using System.Security.Claims;

namespace BugTracker.Core.Contracts
{
    public interface IValidationService
    {
        (bool, DateTime) ValidateDate(string model);

        bool AreDatesValid(DateTime appearedOn, DateTime isAfterDate);

        bool OrganizationName(string organizationName);
    }
}
