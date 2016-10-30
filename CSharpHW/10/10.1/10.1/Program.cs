using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10001];
            InitArr(arr);
            Console.WriteLine(GetNonPairMember(arr));
        }

        public static int GetNonPairMember(int[] arr)
        {
            int n = 0;
            int size = arr.Length;
            for (int i = 0; i < size; ++i)
                n ^= arr[i];

            return n;
        }

        public static void InitArr(int[] arr)
        {
            int size = 10001;
            for(int i = 1, j = 1; i <= size; ++i)
            {
                if (i % 2 == 0)
                    ++j;
                arr[i-1] = j;
            }
        }
    }
}
