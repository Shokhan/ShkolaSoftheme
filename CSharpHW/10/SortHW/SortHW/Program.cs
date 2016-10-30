using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 8, 4, 3, 6, 27, 15, 34, 11, 23, 54, 67 , 88, 12};
            Show(arr);
            Sort s = new Sort();
            s.SortArray(arr);
            Show(arr);
        }
        
        static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }
    }
}
