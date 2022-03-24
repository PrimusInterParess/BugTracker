namespace BugTracker.Models.ViewModels.Department
{
    using System.ComponentModel.DataAnnotations;
    using static Constants.IntegerConstants;
    using static Constants.MessageConstants;
    public class AddDepartmentFormModel
    {
        [Required]
        [StringLength(DefaultMaxLength,MinimumLength = DefaultMinLength,ErrorMessage = DefaultStringLengthErrorMessage)]
        public string Name { get; set; }

        [Required]
        [StringLength(DefaultMaxLength, MinimumLength = DefaultMinLength, ErrorMessage = DefaultStringLengthErrorMessage)]
        public string Organization { get; set; }

        //TODO FIX it!!!
        public string? OrganizationId { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DefaultMinLength, ErrorMessage = DefaultStringLengthErrorMessage)]
        public string DepartmentSubject { get; set; }
    }
}
