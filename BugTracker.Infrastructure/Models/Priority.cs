namespace BugTracker.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static ModelsConstants.IntegerModelConstants;

    public class Priority
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Name { get; set; }

        public ICollection<Bug> PriorityBugs { get; set; } = new HashSet<Bug>();
    }
}
