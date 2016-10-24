using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    class Human
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }

        public Human(string fName, string lName, DateTime birthday) : this(fName, lName)
        {
            BirthDate = birthday;

            Age = DateTime.Now.Year - BirthDate.Year;
            if ((DateTime.Now.Month - BirthDate.Month) < 0)
                --Age;
        }
        private Human(string name, string lname)
        {
            FirstName = name;
            LastName = lname;
        }

        public static bool operator==(Human h1, Human h2)
        {
            if (h1.Age != h2.Age)
                return false;
            else if (h1.FirstName != h2.FirstName)
                return false;
            else if (h1.LastName != h2.LastName)
                return false;
            else if (h1.BirthDate != h2.BirthDate)
                return false;

            return true;
        }

        public static bool operator!=(Human h1, Human h2)
        {
            return !(h1 == h2);
        }
    }
}
