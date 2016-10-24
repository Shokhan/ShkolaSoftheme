using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Denn", "Brown", new DateTime(1993, 7, 2));
            Human h2 = new Human("Denn", "Brown", new DateTime(1993, 7, 2));
            if (h1 == h2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not equal");
        }
    }
}
