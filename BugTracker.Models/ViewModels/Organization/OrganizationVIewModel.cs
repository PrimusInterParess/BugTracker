using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Models.ServiceModels.Department;

namespace BugTracker.Models.ViewModels.Organization
{
    public class OrganizationVIewModel
    {
        public string Id { get; init; }

        public string Name { get; init; }

        public string? StreetName { get; set; }


        public string StreetNumber { get; set; }

        public string TownName { get; set; }


        public string Country { get; set; }

        public string LogoUrl { get; set; }

        [Display(Name ="All Departments")]
        public string DeparmtmentId { get; set; }

        public ICollection<DepartmentServiceModel> Departments { get; set; } = new HashSet<DepartmentServiceModel>();
    }
}
