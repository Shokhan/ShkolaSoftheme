using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    public static class Validator
    {
        public static IEnumerable<string> Validate(object o)
        {
            return System.ComponentModel.TypeDescriptor
                .GetProperties(o.GetType())
                .Cast<PropertyDescriptor>()
                .SelectMany(pd => pd.Attributes.OfType<ValidationAttribute>()
                                    .Where(va => !va.IsValid(pd.GetValue(o))))
                                    .Select(xx => xx.ErrorMessage);
        }
    }
}
