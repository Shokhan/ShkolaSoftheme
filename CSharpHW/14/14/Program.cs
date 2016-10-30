using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Lottery lottery = new Lottery();
                    lottery.GenerateNumbers();
                    Console.WriteLine("Answer to check programm;");
                    ShowAnser(lottery);
                    Console.WriteLine("Enter 6 numbers");
                    string input = Console.ReadLine();
                    Check(input, lottery);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Input can take only 6 numbers.");
                }
            }
        }

        public static void ShowAnser(Lottery lottery)
        {
            for (int i = 0; i < Lottery.Size; ++i)
                Console.Write(lottery[i]);
            Console.WriteLine();
        }
        public static void Check(string input, Lottery lottery)
        {
            if (!lottery.Validate(input))
                throw new Exception();
            bool win = true;
            for (int i = 0; i < Lottery.Size; ++i)
                if (lottery[i] != int.Parse(input[i].ToString()))
                    win = false;

            if (win)
                Console.WriteLine("Congratulation. You Won!!!");
            else
            {
                Console.WriteLine("You lost. Answer is:");
                ShowAnser(lottery);
            }

        }
    }
}
