using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Core.Contracts;
using BugTracker.Infrastructure.Data;
using BugTracker.Infrastructure.Data.Models;
using BugTracker.Models.ServiceModels.Employee;

namespace BugTracker.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly BugTrackerDbContext _data;

        public EmployeeService(BugTrackerDbContext data)
        {
            _data = data;
        }

        public ICollection<EmployeeServiceModel> GetEmployeesByDepartmentId(string departmentId)
            => _data
                .Employees
                .Where(e => e.DepartmentId == departmentId)
                .Select(e => new EmployeeServiceModel()
                {
                    Id = e.Id,
                    Name = e.Name
                }).ToList();

        public bool Save(string name, string email, string organizationId, string departmentId)
        {
            var employeeData = new Employee()
            {
                Name = name,
                Email = email,
                OrganizationId = organizationId,
                DepartmentId = departmentId,

            };
            
            try
            {
                _data.Employees.Add(employeeData);
                _data.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
