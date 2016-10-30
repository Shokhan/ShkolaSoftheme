using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program 
    {
        static void Main(string[] args)
        {
            string name = "";
            string password = "";
            string email = "";
            Validator validator = new Validator();

            while(true)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                email = Console.ReadLine();

                if (email == "exit" || name == "exit" || password == "exit")
                    break;

                User user = new User() { Name = name, Password=password, Email = email };
                if(!validator.ValidateUser(user))
                {
                    user.lastVisit = DateTime.Now;
                    validator.Add(new User(user));
                    Console.WriteLine("User is added");
                }
                else
                {
                    validator.ShowInfo(user);
                }

            }
        }
    }
}
