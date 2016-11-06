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

        [Required(ErrorMessage ="Field day should contain data")]
        [Range(1, 31, ErrorMessage ="Invalid day.")]
        public int Day { get; set; }

        [Required(ErrorMessage = "Field month should contain data")]
        [Range(1, 12, ErrorMessage = "Invalid month.")]
        public int Month { get; set; }

        [Required(ErrorMessage = "Field year should contain data")]
        [Range(1900, 2017, ErrorMessage = "Invalid year.")]
        public int Year { get; set; }
        
        [Required(ErrorMessage = @"Field male/female should contain one of these status")]
        public string Sex { get; set; }

        [Required(ErrorMessage ="Field phone number should contain data")]
        [Phone(ErrorMessage ="Incorrect phone number")]
        public string PhoneNumber { get; set; }

        [StringLength(500, ErrorMessage ="Additional info should be less than 500 characters")]
        public string additionalInfo { get; set; }
    }
}
