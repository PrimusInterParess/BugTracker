namespace BugTracker.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using BugTracker.Infrastructure.Models;
    using System.ComponentModel.DataAnnotations;
    using static ModelsConstants.IntegerModelConstants;
    using ModelsConstants;

    public class Organization
    {
        [Key]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Name { get; init; }

        [Required]
        public string? StreetName { get; set; }

        [Required]
        public string LogoUrl { get; set; }

        [Required]
        [StringLength(DefaultMaxLength)]
        public string StreetNumber { get; set; }
        [Required]

        [StringLength(DefaultMaxLength)]
        public string TownName { get; set; }

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Country { get; set; }

        public string AdministratiorId { get; set; }
        [ForeignKey(nameof(AdministratiorId))]
        public Administrator Administrator { get; set; }

        public ICollection<Department> Departments { get; set; } = new HashSet<Department>();

        public ICollection<Project> OrganizationProjects { get; set; } = new HashSet<Project>();

        public ICollection<Employee> OrganizationEmployees { get; set; } = new HashSet<Employee>();
    }
}
