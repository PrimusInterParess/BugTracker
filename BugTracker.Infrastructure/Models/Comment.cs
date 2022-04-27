namespace BugTracker.Infrastructure.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using BugTracker.Infrastructure.ModelsConstants;
    using BugTracker.Infrastructure.Data.Models;
    using static BugTracker.Infrastructure.ModelsConstants.IntegerModelConstants;

    public class Comment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Content { get; set; }

        public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public Employee User { get; set; }

        public string? BugId { get; set; }

        [ForeignKey(nameof(BugId))]
        public Bug Bug { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime EditedOn { get; set; } = DateTime.Now;


    }
}
