using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PatientProject.PatientPages
{
    public class DateValidationClass : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            DateTime time;
            if (!DateTime.TryParse((value ?? "").ToString(), CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal | DateTimeStyles.AllowWhiteSpaces, out time))
                return new ValidationResult(false, "Format datuma nije dobar!");

            return time.Date <= DateTime.Now.Date
                ? new ValidationResult(false, "Molim vas unesite datum u buducnosti!")
                : ValidationResult.ValidResult;
        }

    }
    
}
