using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPainting
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 1999, "black");
            car.showInfo();
            TuningAtelier.paintCar(car);
            Console.WriteLine("Car after atelier");
            car.showInfo();
        }
    }
}
