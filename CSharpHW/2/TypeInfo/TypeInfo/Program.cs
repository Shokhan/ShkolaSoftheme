using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
              typeof(sbyte).ToString(), sbyte.MaxValue, sbyte.MinValue, default(sbyte));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
                typeof(int).ToString(), int.MaxValue, int.MinValue, default(int));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
                typeof(long).ToString(), long.MaxValue, long.MinValue, default(long));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
                typeof(float).ToString(), float.MaxValue, float.MinValue, default(float));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
                typeof(double).ToString(), double.MaxValue, double.MinValue, default(double));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
                typeof(decimal).ToString(), decimal.MaxValue, decimal.MinValue, default(decimal));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
               typeof(byte).ToString(), byte.MaxValue, byte.MinValue, default(byte));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
               typeof(uint).ToString(), uint.MaxValue, uint.MinValue, default(uint));

            Console.WriteLine("Type = {0}, Max = {1}, Min={2}, default = {3};",
                typeof(ulong).ToString(), ulong.MaxValue, ulong.MinValue, default(ulong));
        }

    }
}
