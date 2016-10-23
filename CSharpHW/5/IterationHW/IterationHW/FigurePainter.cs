using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationHW
{
    class FigurePainter
    {
        public void DrawRect()
        {
            Console.WriteLine("Enter size of rectangle.");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public void DrawTriangle()
        {
            int size;
            while(true)
            {
                Console.WriteLine("Choose any size more than 1");
                size = int.Parse(Console.ReadLine());
                if (size < 2)
                {
                    Console.WriteLine("Incorrect size. Try again.");
                    continue;
                }
                else
                    break;
            }

            Console.WriteLine();
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j <= i; ++j)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public void DrawRhombus()
        {
            int size;
            while(true)
            {
                Console.WriteLine("Input non pair number that more than 2");
                size = int.Parse(Console.ReadLine());

                if (size < 3 || (size % 2) == 0)
                {
                    Console.WriteLine("Incorrect size. Try again.");
                    continue;
                }
                else
                    break;
            }

            int mid = size / 2;
            for(int i = 0; i < size; ++i)
            {
                for(int j = 0; j < size; ++j)
                {
                    if (i <= mid)
                    {
                        if (j >= (mid - i) && j <= (mid + i))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j > (i - mid - 1) && j < (size - (i % mid)))
                        {
                            Console.Write("*");
                            if (i == size - 1)
                                break;
                        }
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
