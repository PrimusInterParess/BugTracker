using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Models.ViewModels.Employee;

namespace BugTracker.Models.ViewModels.Bug
{
    public class BugViewModel
    {
        public string Id { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public DateTime AppearedOn { get; set; }

        public DateTime DueDate { get; set; }

        public string Project { get; set; }

        public ICollection<EmployeeViewModel> BugEmployees { get; set; } = new List<EmployeeViewModel>();
    }
}
