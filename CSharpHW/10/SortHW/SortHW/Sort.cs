using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortHW
{
    public class Sort
    {
        public void SortArray(int[] arr)
        {
            QuickSort(arr, 0, arr.Length-1);
        }

        private void QuickSort(int[] arr, int l, int r)
        {
            int i = l, j = r;
            int pivot = arr[(r+l)/2];

            while(i <= j)
            {
                while (arr[i] < pivot)
                    ++i;
                while (arr[j] > pivot)
                    --j;
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    ++i; --j;
                }
            }

            if (l < j)
                QuickSort(arr, l, j);
            if (i < r)
                QuickSort(arr, i, r);
        }


        private void Swap(ref int l, ref int r)
        {
            int t = l;
            l = r;
            r = t;
        }
    }
}
