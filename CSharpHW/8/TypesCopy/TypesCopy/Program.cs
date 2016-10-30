using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 3;
            Console.WriteLine("a = {0}, b = {1}", a.ToString(), b.ToString());
            a = b;
            Console.WriteLine("a = {0}, b = {1}", a.ToString(), b.ToString());

            User u1 = new User(1, "Sherlok");
            User u2 = new User(2, "Watson");

            Console.WriteLine("User1:");
            u1.Show();
            Console.WriteLine("User1:");
            u2.Show();

            User u3 = u1;
            Console.WriteLine("User3");
            u3.Show();

            u3.UserName = "Morty";
            Console.WriteLine("User1:");
            u1.Show();
        }
    }
}
