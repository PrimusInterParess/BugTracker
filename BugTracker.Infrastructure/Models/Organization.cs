using BugTracker.Infrastructure.ModelsConstants;

namespace BugTracker.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;
  using static IntegerModelConstants;

    public class Organization
    {
        [Key]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]

        public string Name { get; init; }

        public string? StreetName { get; set; }

        [Required]
        [StringLength(DefaultMaxLength)]
        public string StreetNumber { get; set; }
        [Required]

        [StringLength(DefaultMaxLength)]
        public string TownName { get; set; }

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Country { get; set; }

        public ICollection<Department> OrganizationDepartments { get; set; } = new HashSet<Department>();
    }
}
