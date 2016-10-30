using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(5);
            list.Add(7);
            list.Add(2);
            list.Add(4);
            list.Add(8);
            list.Add(3);
            list.Show();
            Console.WriteLine("Number of elements: {0}", list.Size);

            Console.WriteLine("After Delete");
            list.Delete(5);
            list.Delete(2);
            list.Delete(3);
            list.Show();
            Console.WriteLine("Number of elements: {0}", list.Size);

            Console.WriteLine("Is available(7): {0}", list.IsAvalable(7));

            Console.WriteLine("ToArray");
            var arr = list.ToArray();
            for (int i = 0; i < arr.Length; ++i)
                Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }
    }
}
