using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.CompilerServices;
using static BugTracker.Infrastructure.ModelsConstants.Constants;
namespace BugTracker.Infrastructure.Data.Models
{
    public class Department

    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; }

        public string OrganizationId { get; set; }

        [ForeignKey(nameof(OrganizationId))]
        public Organization Organization { get; set; }

        public string DepartmentSubject { get; set; }

        public ICollection<Project> Projects { get; set; } = new HashSet<Project>();

        public ICollection<Employee> DepartmentEmployees { get; set; } = new HashSet<Employee>();
    }
}
