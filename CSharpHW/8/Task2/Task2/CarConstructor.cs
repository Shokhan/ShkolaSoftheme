using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class CarConstructor
    {
        public Car Construct(Transmission t, Color c, Engine e, string carName = "BMW")
        {
            Car car = new Car();
            car.Name = carName;
            car.Color = c;
            car.Engine = e;
            car.Transmission = t;
            return car;
        }

        public void Reconstruct(Car car, Engine e)
        {
            car.Engine = e;
        }
    }
}
