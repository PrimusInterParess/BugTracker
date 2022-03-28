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
            var errors = new Dictionary<string, string>();

            var appearedDate = bug.AppearedOn;
            var dueDate = bug.DueDate;

            if (this.validationService.AreDatesValid(appearedDate, dueDate) == false)
            {
                errors.Add(nameof(bug.DueDate), InvalidDateMessage);
                errors.Add(nameof(bug.AppearedOn), InvalidDateMessage);
            }


            return errors;
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

        public bool Save(AddBugFormModel bug)
        {
            var bugData = new Bug()

            {
                AppearedOn = bug.AppearedOn,
                DueDate = bug.DueDate,
                Description = bug.Description,
                PriorityId = bug.PriorityId,
                StatusId = bug.StatusId,
                ProjectId = bug.PriorityId,
                Title = bug.Title,
                //TODo : add employees features
            };

            try
            {
                repo.Add(bugData);
                repo.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

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
