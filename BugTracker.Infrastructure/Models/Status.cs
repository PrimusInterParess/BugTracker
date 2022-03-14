using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BugTracker.Infrastructure.ModelsConstants.Constants;
namespace BugTracker.Infrastructure.Data.Models
{
    public class Status
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Bug> StatusBugs { get; set; } = new HashSet<Bug>();

    }
}
