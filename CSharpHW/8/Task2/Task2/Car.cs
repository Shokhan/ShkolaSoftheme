using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Car
    {
        public string Name { get; set; }
        public Transmission Transmission { get; set; }
        public Color Color { get; set; }
        public Engine Engine { get; set; }

        public void Show()
        {
            Console.WriteLine("CarName = {0}, Color = {1}, Engine = {2}, Transmission = {3}",
                Name, Color.NameOfCol, Engine.Name, Transmission.TrasmName);
        }
    }
}
