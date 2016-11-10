using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DecisionMaking
{
    public class User
    {
        [Required(ErrorMessage ="Field name should contain data.")]
        [StringLength(255, ErrorMessage ="Name should less than 255 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Field last name should contain data.")]
        [StringLength(255, ErrorMessage = "Last name should less than 255 characters")]
        public string LstName { get; set; }

        [Date(DateAttribute.DatePart.Day)]
        public string Day { get; set; }

        [Date(DateAttribute.DatePart.Month)]
        public string Month { get; set; }

        [Date(DateAttribute.DatePart.Year)]
        public string Year { get; set; }
        
        [EmailAddress(ErrorMessage ="Incorrect Email")]
        public string Email { get; set; }
        [Gender]
        public string Sex { get; set; }

        //[Required(ErrorMessage ="Field phone number should contain data")]
        [Phone(ErrorMessage ="Incorrect phone number")]
        public string PhoneNumber { get; set; }

        [StringLength(500, ErrorMessage ="Additional info should be less than 500 characters")]
        public string additionalInfo { get; set; }
    }
}
