

namespace BugTracker.Models.ViewModels.Project
{
    using BugTracker.Models.ViewModels.Department;
    using Microsoft.AspNetCore.Mvc;
    using static Models.Constants.FormatingConstants;
    using System.ComponentModel.DataAnnotations;
    using static Models.Constants.IntegerConstants;

    public class AddProjectFormModel
    {
        [Required]
        [StringLength(DefaultMaxLength)]
        public string Name { get; set; }

        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = AttributeDateFormat, ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = AttributeDateFormat, ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        public string DepartmentId { get; set; }


    }
}
