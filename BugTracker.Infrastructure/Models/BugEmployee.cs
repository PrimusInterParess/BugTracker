using BugTracker.Infrastructure.Data.Models;

namespace BugTracker.Infrastructure.Models
{
    public class BugEmployee
    {
        public string BugId { get; set; }

        public Bug Bug { get; set; }

        public string EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
