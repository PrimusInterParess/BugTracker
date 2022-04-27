using BugTracker.Infrastructure.Data.Models;

namespace BugTracker.Infrastructure.Models;

public class ProjectEmployee
{
    public string EmployeeId { get; set; }

    public Employee Employee { get; set; }

    public string ProjectId { get; set; }

    public Project Project { get; set; }

}