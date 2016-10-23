using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationHW
{
    class Program
    {
        static void Main(string[] args)
        {
            FigurePainter fig = new FigurePainter();

            while(true)
            {
                try
                {
                    int input = 0;
                    while (true)
                    {
                        Console.WriteLine("1. Rectangle. \n2.Rhombus. \n3. Triangle.");
                        input = int.Parse(Console.ReadLine());
                        if (input < 1 && input > 3)
                            Console.WriteLine("Incorect input. Try again.");
                        else
                            break;
                    }

                    switch (input)
                    {
                        case 1:
                            fig.DrawRect();
                            break;
                        case 2:
                            fig.DrawRhombus();
                            break;
                        case 3:
                            fig.DrawTriangle();
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input allows only numeric integer types. Try to input correctly");
                }
            }
        }
    }
}
