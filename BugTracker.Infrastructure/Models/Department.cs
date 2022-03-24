namespace BugTracker.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static ModelsConstants.IntegerModelConstants;
    public class Department

    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Name { get; set; }

        [ForeignKey(nameof(Organization))]
        public string OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public string DepartmentSubject { get; set; }

        public ICollection<Project> Projects { get; set; } = new HashSet<Project>();

        public ICollection<Employee> DepartmentEmployees { get; set; } = new HashSet<Employee>();
    }
}
