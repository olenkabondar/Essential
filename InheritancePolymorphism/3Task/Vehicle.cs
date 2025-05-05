using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Task
{
    internal class Vehicle
    {
        //координати
        public double X { get; set; }
        public double Y { get; set; }

        //параметри суден
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }
        public Vehicle(double x, double y, decimal price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Location: ({X}, {Y})");
            Console.WriteLine($"Price: {Price} USD");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Year: {Year}");
        }
    }
}
