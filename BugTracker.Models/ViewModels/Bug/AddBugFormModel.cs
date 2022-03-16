namespace BugTracker.Models.ViewModels.Bug
{
    using Priority;
    using Status;
    using Microsoft.AspNetCore.Mvc;
    using System.ComponentModel.DataAnnotations;
    using static Constants.IntegerConstants;

    public class AddBugFormModel
    {
        [Required]
        [StringLength(DefaultMaxLength, MinimumLength = DefaultMinLength,
            ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string Title { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DefaultMinLength,
            ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string Description { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime AppearedOn { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        [Display(Name = "Priority")]
        public string PriorityId { get; set; }

        [Display(Name = "Status")]
        public string StatusId { get; set; }

        [Required]
        [StringLength(DefaultMaxLength, MinimumLength = DefaultMinLength,
            ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string Project { get; set; }

        public ICollection<PriorityViewModel>? Priorities { get; set; }
        public ICollection<StatusViewModel>? StatusList { get; set; }
    }
}
