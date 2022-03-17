namespace BugTracker.Core.Services
{
    using Contracts;
    using BugTracker.Infrastructure.Data.Models;
    using Models.ViewModels.Bug;
    using Models.ViewModels.Priority;
    using Models.ViewModels.Status;
    using Models.ViewModels.Employee;

    using static Models.Constants.MessageConstants;

    public class BugService : IBugService
    {
        private readonly IValidationService validationService;
        private readonly IRepository repo;

        public BugService(IValidationService validationService,
            IRepository repo)
        {
            this.validationService = validationService;
            this.repo = repo;
        }

        public Dictionary<string, string> ValidateBug(AddBugFormModel bug)
        {
            var result = new Dictionary<string, string>();

            var appearedDate = bug.AppearedOn;
            var dueDate = bug.DueDate;

            if (this.validationService.AreDatesValid(appearedDate, dueDate) == false)
            {
                result.Add(nameof(bug.DueDate), InvalidDateMessage);
                result.Add(nameof(bug.AppearedOn), InvalidDateMessage);
            }


            return result;
        }

        public ICollection<PriorityViewModel> GetPriorities()
            => repo.All<Priority>().Select(s => new PriorityViewModel()
            {
                Name = s.Name,
                Id = s.Id
            })
                .ToList();

        public ICollection<StatusViewModel> GetStatus()
            => repo.All<Status>().Select(s => new StatusViewModel()
            {
                Name = s.Name,
                Id = s.Id
            })
                .ToList();

        public ICollection<BugViewModel> GetAllBugs()
            =>
                this.repo.All<Bug>().Select(b => new BugViewModel()
                {
                    Id = b.Id,
                    AppearedOn = b.AppearedOn,
                    DueDate = b.DueDate,
                    BugEmployees = b.BugEmployees.Select(e => new EmployeeViewModel()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Department = e.Department.Name
                    }).ToList(),

                }).ToList();

    }
}
