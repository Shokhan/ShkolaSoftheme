using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Validator : IValidator
    {
        private static List<User> users = new List<User>();
        private bool IsEqual(IUser user, IUser u)
        {
            if (user.Name == u.Name && user.Password == u.Password
                && user.Email == u.Email)
            {
                return true;
            }
            return false;
        }



        public void Add(User u)
        {
            users.Add(u);
        }

        public void ShowInfo(IUser u)
        {
            int size = users.Count;
            for (int i = 0; i < size; ++i)
                if (IsEqual(u, users[i]))
                {
                    Console.WriteLine(users[i].GetFullInfo());
                    users[i].lastVisit = DateTime.Now;
                }
        }

        public bool ValidateUser(IUser user)
        {
            int size = users.Count;
            for (int i = 0; i < size; ++i)
                if (IsEqual(user, users[i]))
                    return true;
            return false;
        }
    }
}
