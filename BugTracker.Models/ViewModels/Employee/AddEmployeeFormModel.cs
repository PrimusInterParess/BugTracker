using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Models.ServiceModels.Department;
using static BugTracker.Models.Constants.IntegerConstants;
namespace BugTracker.Models.ViewModels.Employee
{
    public class AddEmployeeFormModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [StringLength(DefaultMaxLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(EmailNameMaxLength)]
        public string Email { get; set; }

        public string DepartmentId { get; set; }
        public ICollection<DepartmentServiceModel> Deparmtnets { get; set; }
    }
}
