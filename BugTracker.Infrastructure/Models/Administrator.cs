namespace BugTracker.Infrastructure.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;
    using BugTracker.Infrastructure.Data.Models;

    using static ModelsConstants.IntegerModelConstants;

    public class Administrator
    {
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(DefaultMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(DefaultMaxLength)]
        public string LastName { get; set; }
        [Required]
        [StringLength(EmailNameMaxLength)]
        public string Email { get; set; }

        [Required]
        [StringLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        public ICollection<Organization> Organizations { get; set; } = new List<Organization>();

        public string UserId { get; set; }

    }
}
