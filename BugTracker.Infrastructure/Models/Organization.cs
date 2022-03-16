namespace BugTracker.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Organization
    {
        [Key]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        
        public string Name { get; init; }

        public string AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }

        public ICollection<Department> OrganizationDepartments { get; set; } = new HashSet<Department>();
    }
}
