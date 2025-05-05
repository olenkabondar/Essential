using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Task
{
    internal class Plane: Vehicle
    {
        private int Height { get; set; }
        private int CountPassengers { get; set; }
        public Plane(double x, double y, decimal price, double speed, int year, int height, int countPassengers) : base(x, y, price, speed, year)
        {
            Height = height;
            CountPassengers = countPassengers;
        }

        public override void ShowInfo()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Plane");
            Console.ResetColor();
            Console.WriteLine($"Location: ({X}, {Y})");
            Console.WriteLine($"Price: {Price} USD");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"CountPassengers: {CountPassengers}");
        }
    }
}
