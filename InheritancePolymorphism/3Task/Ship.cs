using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Task
{
    internal class Ship: Vehicle
    {
        private int CountPassengers { get; set; }
        private string Port { get; set; }
        public Ship(double x, double y, decimal price, double speed, int year, int countPassengers, string port) : base(x, y, price, speed, year)
        {
            CountPassengers = countPassengers;
            Port = port;
        }

        public override void ShowInfo()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Ship");
            Console.ResetColor();
            Console.WriteLine($"Location: ({X}, {Y})");
            Console.WriteLine($"Price: {Price} USD");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"CountPassengers: {CountPassengers}");
            Console.WriteLine($"Port: {Port}");
        }
    }
}
