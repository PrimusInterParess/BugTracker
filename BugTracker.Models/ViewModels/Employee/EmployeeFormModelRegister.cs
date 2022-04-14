using BugTracker.Models.ServiceModels.Department;

namespace BugTracker.Models.ViewModels.Employee
{
    using System.ComponentModel.DataAnnotations;
    using static BugTracker.Models.Constants.IntegerConstants;

    public class EmployeeFormModelRegister
    {
        [Required]
        [StringLength(DefaultMaxLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(EmailNameMaxLength)]
        public string Email { get; set; }

        [Required]
        [StringLength(DefaultMaxLength)]

        public string OrganizationName { get; set; }

        [Display(Name = "Department")]
        public string DepartmentId { get; set; }

        public ICollection<DepartmentServiceModel> Departments = new List<DepartmentServiceModel>();

    }
}
