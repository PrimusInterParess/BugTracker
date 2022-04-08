namespace BugTracker.Infrastructure.Models
{
    using Microsoft.AspNetCore.Identity;
    using static ModelsConstants.IntegerModelConstants;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        [StringLength(FullNameMaxLength)]
        public string FullName { get; set; }
    }
}
