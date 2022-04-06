namespace BugTracker.Models.ViewModels.Organization
{
    using System.ComponentModel.DataAnnotations;

    using static Constants.IntegerConstants;
    using static Constants.MessageConstants;


    public class OrganizationFormModel
    {
       [Required]
        [StringLength(DefaultMaxLength, MinimumLength = DefaultMinLength,
            ErrorMessage = DefaultStringLengthErrorMessage)]
        public string Name { get; init; }

        public string? StreetName { get; set; }

        [StringLength(DefaultMaxLength,
            ErrorMessage = DefaultStringLengthErrorMessage)]
        public string? StreetNumber { get; set; }

        [StringLength(DefaultMaxLength, MinimumLength = DefaultMinLength,
            ErrorMessage = DefaultStringLengthErrorMessage)]
        public string TownName { get; set; }

        [StringLength(DefaultMaxLength, MinimumLength = DefaultMinLength,
            ErrorMessage = DefaultStringLengthErrorMessage)]
        public string Country { get; set; }

        [Required]
        public string LogoUrl { get; set; }

    }
}
