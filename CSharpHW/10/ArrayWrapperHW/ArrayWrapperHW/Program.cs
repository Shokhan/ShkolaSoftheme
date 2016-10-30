using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWrapperHW
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
                ArrayWrapper arr = new ArrayWrapper(new int[] { 1, 2, 3, 4 });
                arr.Show();

                arr.Add(1);
                arr.Show();

                Console.WriteLine("Containts(3) = {0}", arr.Contains(2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
