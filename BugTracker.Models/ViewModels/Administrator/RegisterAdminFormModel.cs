namespace BugTracker.Models.ViewModels.Administrator
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Constants.IntegerConstants;
    using static Constants.MessageConstants;

    public class RegisterAdminFormModel
    {
        [Required]
        [StringLength(DefaultMaxLength ,MinimumLength = DefaultMinLength,ErrorMessage = DefaultStringLengthErrorMessage)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(DefaultMaxLength, MinimumLength = DefaultMinLength, ErrorMessage = DefaultStringLengthErrorMessage)]
        public string LastName { get; set; }
        [Required]
        [StringLength(EmailNameMaxLength)]
        public string Email { get; set; }

        [Required]
        [StringLength(PhoneNumberMaxLength,MinimumLength = PhoneNumberMinLength,ErrorMessage = DefaultNumbersLengthErrorMessage)]
        public string PhoneNumber { get; set; }

    }
}
