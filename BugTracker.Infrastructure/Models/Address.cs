namespace BugTracker.Infrastructure.Data.Models
{
    using static ModelsConstants.IntegerModelConstants;
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [StringLength(DefaultMaxLength)]
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

        public ICollection<Organization> Organizations { get; set; } = new HashSet<Organization>();
    }
}
