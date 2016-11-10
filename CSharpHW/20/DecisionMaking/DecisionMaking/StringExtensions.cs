using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    public static class StringExtensions
    {
        public static bool containNumbers(this string str)
        {
            int size = str.Length;
            for (int i = 0; i < size; ++i)
                if (char.IsDigit(str[i]))
                    return true;
            return false;
        }

        public static bool containChar(this string str)
        {
            int size = str.Length;
            for (int i = 0; i < size; ++i)
                if (char.IsLetter(str[i]))
                    return true;
            return false;
        }
    }
}
