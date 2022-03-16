namespace BugTracker.Core.Services
{
    using System.Globalization;
    using BugTracker.Models.Constants;
    using Contracts;
    public class ValidationService : IValidationService
    {
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
            var currentDate = DateTime.UtcNow;

            if (appearedOn >= dueDate || appearedOn>currentDate)
            {
                return false;
            }

            return true;
        }

    }
}
