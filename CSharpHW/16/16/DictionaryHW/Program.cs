using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> s = new MyDictionary<string, string>();
            s.Add("Джон", "John");
            s.Add("Джейк", "Jake");
            s.Add("Ден", "Denn");

            Console.WriteLine(s.Find("Джон"));
            Console.WriteLine(s.Find("Джейк"));
            Console.WriteLine(s.Find("Ден"));
            //for (int i = 1; i <= 3; ++i)
            //Console.WriteLine(s.Find();
        }
    }
}
