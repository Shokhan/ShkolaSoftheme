using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Lottery
    {
        public const int Size = 6;
        private int[] WinValues = new int[Size];

        public void GenerateNumbers()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < Size; ++i)
                WinValues[i] = r.Next(1,10); 
        }

        public bool Validate(string str)
        {
            if (str.Length != Size)
                return false;

            for (int i = 0; i < Size; ++i)
                if (!char.IsDigit(str[i]))
                    return false;

            return true;
        }

        public int this[int index]
        {
            get
            {
                return WinValues[index];
            }
        }
    }
}
