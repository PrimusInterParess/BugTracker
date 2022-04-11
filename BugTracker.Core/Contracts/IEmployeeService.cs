using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Models.ServiceModels.Employee;

namespace BugTracker.Core.Contracts
{
    public interface IEmployeeService
    {
        ICollection<EmployeeServiceModel> GetEmployeesByDepartmentId(string departmentId);

        bool Save(string name,string email,string organizationId,string departmentId);
    }
}
