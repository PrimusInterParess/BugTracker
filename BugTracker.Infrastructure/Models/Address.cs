using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Infrastructure.ModelsConstants;
using static BugTracker.Infrastructure.ModelsConstants.Constants;

namespace BugTracker.Infrastructure.Data.Models
{
    public class Address
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [StringLength(NameMaxLength)]
        public string? StreetName { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string StreetNumber { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string TownName { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Country { get; set; }

        public ICollection<Organization> Organizations { get; set; } = new HashSet<Organization>();
    }
}
