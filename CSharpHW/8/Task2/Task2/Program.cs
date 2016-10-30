using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarConstructor constructor = new CarConstructor();
            Engine engine = new Engine("V12");
            Transmission tr = new Transmission("Best");
            Color color = new Color("Black");

            Car car = constructor.Construct(tr, color, engine);
            car.Show();

            constructor.Reconstruct(car, new Engine("W6"));
            car.Show();
        }
    }
}
