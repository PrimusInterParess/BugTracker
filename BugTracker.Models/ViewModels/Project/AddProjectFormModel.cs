using BugTracker.Models.ViewModels.Department;

namespace BugTracker.Models.ViewModels.Project
{
    using System.ComponentModel.DataAnnotations;
    using static Models.Constants.IntegerConstants;
    public class AddProjectFormModel
    {
        public string Name { get; set; }

        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime DueDate { get; set; }

        [Display(Name = "Department")]
        public string DepartmentId { get; set; }

        public ICollection<DepartmentViewModel>? Departments { get; set; }

    }
}
