using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models.ServiceModels
{
    public class AdministratorServiceModel
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? OrganizationId { get; set; }
    }
}
