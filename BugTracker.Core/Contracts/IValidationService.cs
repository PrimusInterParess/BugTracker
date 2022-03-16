using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Core.Contracts
{
    public interface IValidationService
    {
        (bool, DateTime) ValidateDate(string model);

        bool AreDatesValid(DateTime appearedOn, DateTime isAfterDate);

    }
}
