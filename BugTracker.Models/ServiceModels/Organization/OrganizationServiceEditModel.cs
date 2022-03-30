using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models.ServiceModels.Organization
{
    public class OrganizationServiceEditModel
    {
        public string Id { get; init; }

        public string Name { get; init; }

        public string? StreetName { get; set; }


        public string StreetNumber { get; set; }

        public string TownName { get; set; }


        public string Country { get; set; }

        public string LogoUrl { get; set; }
    }
}
