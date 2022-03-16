namespace BugTracker.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static ModelsConstants.IntegerModelConstants;
    public class Bug
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public string StatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        public Status Status { get; set; }

        public string PriorityId { get; set; }

        [ForeignKey(nameof(PriorityId))]
        public Priority Priority { get; set; }

        public DateTime AppearedOn { get; set; }

        public DateTime DueDate { get; set; }

        public string ProjectId { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }

        public ICollection<Employee> BugEmployees { get; set; } = new HashSet<Employee>();

    }
}
