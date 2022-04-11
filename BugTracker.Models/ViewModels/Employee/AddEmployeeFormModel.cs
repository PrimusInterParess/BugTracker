namespace BugTracker.Models.ViewModels.Employee
{
    using System.ComponentModel.DataAnnotations;
    using static BugTracker.Models.Constants.IntegerConstants;

    public class AddEmployeeFormModel
    {
     
        [StringLength(DefaultMaxLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(EmailNameMaxLength)]
        public string Email { get; set; }

    }
}
