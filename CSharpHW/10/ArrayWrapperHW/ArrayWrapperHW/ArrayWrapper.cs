using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWrapperHW
{
    class ArrayWrapper
    {
        private int [] array;
        public ArrayWrapper(int[] ar)
        {
            array = ar;
        }

        public void Add(int val)
        {
            int size = array.Length;
            int[] temp = new int[size + 1];

            for (int i = 0; i < size; ++i)
                temp[i] = array[i];

            temp[size] = val;
            array = temp;
        }

        public bool Contains(int val)
        {
            int size = array.Length;
            for (int i = 0; i < size; ++i)
                if (array[i] == val)
                    return true;
            return false;
        }
        public void Show()
        {
            for (int i = 0; i < array.Length; ++i)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }

        public int GetByIndex(int ind)
        {
            return array[ind];
        }
    }
}
