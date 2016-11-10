using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class GenderAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string str = ((string)value).ToString();
            if (str == "male" || str == "female")
                return true;

            ErrorMessage = "Gender should be either male or female";
            return false;
        }
    }

    class DateAttribute : ValidationAttribute
    {
        public enum DatePart { Day, Month, Year}
        private DatePart _datePart;

        public DateAttribute(DatePart d)
        {
            _datePart = d;
        }

        public override bool IsValid(object value)
        {
            string date = ((string)value);
            string error = string.Empty;

            if (date == string.Empty || date.containChar())
            {
                error += "Incorrect date input\n";
                return false;
            }

            int d = int.Parse(date);
            if (_datePart == DatePart.Day)
            {
                if (d < 1 || d > 31)
                {
                    error += "Incorrect day\n";
                }
            }
            else if(_datePart == DatePart.Month)
            {
                if (d < 1 || d > 12)
                {
                    error += "Incorrect month\n";
                }
            }
            else if(d < 1900 || d > DateTime.Now.Year)
            {
                error += "Incorrect year";
            }
            
            if(error != string.Empty)
            {
                ErrorMessage = error;
                return false;
            }

            return true;
        }
    }
}
