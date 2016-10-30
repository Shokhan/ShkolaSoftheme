using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string str)
        {
            base.Print(str);
        }

        public void Print(Photo photo)
        {
            Console.WriteLine(photo.MyPhoto);
        }
    }
}
