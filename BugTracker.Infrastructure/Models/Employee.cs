namespace BugTracker.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static ModelsConstants.IntegerModelConstants;

    public class Employee
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(EmailNameMaxLength)]
        public string Email { get; set; }

        public string DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
   
        public Department Department { get; set; }

        public ICollection<Bug> EmployeeBugs { get; set; } = new HashSet<Bug>();

        public ICollection<Employee> ProjectEmployees { get; set; } = new HashSet<Employee>();

    }
}
