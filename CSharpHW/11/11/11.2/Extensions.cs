using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11._1;

namespace _11._2
{
    public static class Extensions
    {
        public static void PrintStrings(this Printer p, string[] strs)
        {
            int size = strs.Length;
            for (int i = 0; i < size; ++i)
                p.Print(strs[i]);
        }

        public static void ColorPrint(this ColourPrinter p, string[] strs,
            Colour[] colours)
        {
            int size = strs.Length;
            int colLastInd = colours.Length - 1;
            for(int i = 0, c = 0; i < size; ++i)
            {
                p.Print(strs[i], colours[c]);

                if (c < colLastInd)
                    ++c;
            }
        }

        public static void PrintPhotos(this PhotoPrinter p, Photo[] photos)
        {
            int size = photos.Length;
            for (int i = 0; i < size; ++i)
                Console.WriteLine(photos[i]);
        }
    }
}
