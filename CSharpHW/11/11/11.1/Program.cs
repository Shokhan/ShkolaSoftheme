using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("This is printer!!\n");

            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print("This is photo printer!!\n");
            photoPrinter.Print(new Photo { MyPhoto = "Photo" });

            ColourPrinter colPrinter = new ColourPrinter();
            colPrinter.Print("This is colour printer");
            colPrinter.Print("Colour text.\n", new Colour() { MyColour = ConsoleColor.Green });


        }
    }
}
