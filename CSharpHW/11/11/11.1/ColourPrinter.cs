using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    public class ColourPrinter : Printer
    {
        public override void Print(string str)
        {
            base.Print(str);
        }

        public void Print(string str, Colour col)
        {
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = col.MyColour;
            Console.WriteLine(str);
            Console.ForegroundColor = temp;
        }
    }
}
