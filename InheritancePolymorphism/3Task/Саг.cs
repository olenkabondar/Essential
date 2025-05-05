using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Task
{
    internal class Car : Vehicle
    {
        public Car(double x, double y, decimal price, double speed, int year) : base(x, y, price, speed, year)
        {
        }

        public override void ShowInfo()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Car");
            Console.ResetColor();
            Console.WriteLine($"Location: ({X}, {Y})");
            Console.WriteLine($"Price: {Price} USD");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Year: {Year}");
        }
    }
}
