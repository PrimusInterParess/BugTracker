using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Models.ServiceModels.Department;
using BugTracker.Models.ViewModels.Department;

namespace BugTracker.Core.Contracts
{
    public interface IDepartmentService
    {
        bool ValidateDepartmentName(string departmentName,string organizationId);

        bool Save(AddDepartmentFormModel department);
       List<DepartmentServiceModel> GetAllDepartments(string organizationId);
        DepartmentViewModel GetDepartment(string departmentId);
    }
}
