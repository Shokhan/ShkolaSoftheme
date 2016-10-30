using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class User : IUser
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public DateTime lastVisit { get; set; }

        public string GetFullInfo()
        {
            return string.Format("Name: {0}.\n Password: {1}.\nEmail: {2}.\nLast Visit: {3}.\n",
                Name, Password, Email, lastVisit);
        }

        public User(User u)
        {
            Name = u.Name;
            Password = u.Password;
            Email = u.Email;
            lastVisit = u.lastVisit;
        }

        public User()
        {

        }
    }
}
