using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPainting
{
    class Car
    {
        public string _model { get; } 
        public int _year { get; }
        public string _color { get; set; }

        public Car(string model, int year, string color)
        {
            _model = model;
            _year = year;
            _color = color;
        }

        public void showInfo()
        {
            Console.WriteLine("Model: {0}, Year: {1}, Color {2}.", _model, _year, _color);
        }
    }
}
