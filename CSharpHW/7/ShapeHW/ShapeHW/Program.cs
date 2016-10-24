using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHW
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeDescriptor [] shDescript1 = new ShapeDescriptor[]
            {
                new ShapeDescriptor(new Point(1,1)),
                new ShapeDescriptor(new Point(1,1), new Point(1,1)),
                new ShapeDescriptor(new Point(1,1), new Point(1,1), new Point(1,1)),
                new ShapeDescriptor(new Point(1,1), new Point(1,1), new Point(1,1), new Point(1,1))
            };

            for (int i = 0; i < shDescript1.Length; ++i)
                Console.WriteLine(shDescript1[i].ShapeType);
        }
    }
}
