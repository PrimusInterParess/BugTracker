namespace BugTracker.Core.Contracts;

using Models.ViewModels.Bug;
using Models.ViewModels.Priority;
using Models.ViewModels.Status;

public interface IBugService
{
    Dictionary<string,string> ValidateBug(AddBugFormModel bug);

    ICollection<PriorityViewModel> GetPriorities();
    ICollection<StatusViewModel> GetStatus();
}