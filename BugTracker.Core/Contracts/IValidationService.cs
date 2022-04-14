using System.Security.Claims;

namespace BugTracker.Core.Contracts
{
    public interface IValidationService
    {
        (bool, DateTime) ValidateDate(string model);

        bool AreDatesValid(DateTime appearedOn, DateTime isAfterDate);

        bool OrganizationName(string organizationName);

        bool OrganizationId(string organizationId);

        bool DepartmentOrganization(string departmentId, string organizationId);

        bool DepartmentId(string departmentId);

        bool ProjectNameExists(string name, string departmentId);
    }
}
