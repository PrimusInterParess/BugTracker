using System.Security.Claims;
using BugTracker.Infrastructure.Data;

namespace BugTracker.Core.Services
{
    using System.Globalization;
    using Models.Constants;
    using Contracts;

    public class ValidationService : IValidationService
    {
        private readonly BugTrackerDbContext _repo;

        public ValidationService(BugTrackerDbContext repo)
        {
            this._repo = repo;
        }

        public (bool, DateTime) ValidateDate(string model)
        {
            DateTime date;

            var isValid = DateTime.TryParseExact(
                model,
                FormatingConstants.NormalDateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date);

            return (isValid, date);
        }

        public bool AreDatesValid(DateTime appearedOn, DateTime dueDate)
        {
            var currentDate = DateTime.Now;

            if (appearedOn >= dueDate ||
                appearedOn > currentDate)
            {
                return false;
            }

            return true;
        }

        public bool IsAdmin(ClaimsPrincipal user)
        {
            var userId = user.FindFirst(ClaimTypes.NameIdentifier).ToString();

            if (userId == null)
            {
                return false;
            }

            return this._repo.Administrators.Any(a => a.Id == userId);
        }

        //public void Test()
        //{
        //    var organization = _repo.Organizations.FirstOrDefault(o => o.Name == "DaniBorisov OOD");

        //    var dep = new Department()
        //    {
        //        Name = "dsadadada depdgasdx4213421",
        //        OrganizationId = organization.Id,
        //        Organization = organization,
        //        DepartmentSubject = "ole-male4213asdfwASCZXGTWFASZX21321"

        //    };

        //    organization.Departments.Add(dep);

        //    _repo.SaveChanges();

        //    [Key]
        //public string Id { get; set; } = Guid.NewGuid().ToString();

        //[Required]
        //[StringLength(DefaultMaxLength)]
        //public string Name { get; set; }

        //public string OrganizationId { get; set; }

        //[ForeignKey(nameof(OrganizationId))]
        //public Organization Organization { get; set; }

        //public string DepartmentSubject { get; set; }

        //public ICollection<Project> Projects { get; set; } = new HashSet<Project>();

        //    //public ICollection<Employee> DepartmentEmployees { get; set; } = new HashSet<Employee>();
        //}

        //public void DisplayAll()
        //{
        //    //var organization = _repo
        //    //    .Organizations
        //    //    .Include(O=>O.Departments)
        //    //    .FirstOrDefault(d=>d.Name== "DaniBorisov OOD");

        //    var organization = 

        //    foreach (var dep in organization.Departments)
        //    {
        //        Console.WriteLine(dep.Name);
        //    }

        //}
    }

}
