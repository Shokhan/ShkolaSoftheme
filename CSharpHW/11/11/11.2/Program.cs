using _11._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.PrintStrings(new string[]{"First string.","Second string."});

            PhotoPrinter p2 = new PhotoPrinter();
            p2.PrintPhotos(new Photo[] { new Photo {MyPhoto = "Photo 1"},
                                         new Photo { MyPhoto ="Photo 2" } });

            ColourPrinter p3 = new ColourPrinter();
            p3.ColorPrint(new string[] { "First string.", "Second string." },
                new Colour[] { new Colour { MyColour = ConsoleColor.Blue }, new Colour { MyColour = ConsoleColor.Magenta } });


        }
    }
}
