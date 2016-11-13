using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWPF
{
    public static class StringExtensions
    {
        public static bool OnlyDigits(this string str)
        {
            int size = str.Length;
            for(int i = 0; i < size; ++i)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
