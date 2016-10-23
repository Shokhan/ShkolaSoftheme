using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while(true)
            {
                try
                {
                    Console.WriteLine("Input your birthday in format DD/MM/YYYY");
                    string input = Console.ReadLine();
                    AgeZodiacInfo info = new AgeZodiacInfo(input);
                    Console.WriteLine("Age = {0}\nZodiac={1}",info.GetAge(), info.determineZodiac());
                    Console.ReadKey();
                    break;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Incorrect input. Input correct date!!");
                    continue;
                }
            }         
        }
    }
}
