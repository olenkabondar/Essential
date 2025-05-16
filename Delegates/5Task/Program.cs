using System;
using System.Text;

namespace _5Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть анонімний метод, який приймає як параметри три цілих аргументи і повертає середнє арифметичне цих аргументів.*/
    internal class Program
    {
        delegate double AverageCalculator(int a, int b, int c);
        static void Main(string[] args)
        {
            //описуємо анонімний метод AverageCalculator з використанням лямбда виразу
            AverageCalculator averageCalculator = null;
            averageCalculator += (a,b,c) => (double)(a + b + c) / 3;

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть перше ціле число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге ціле число:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть третє ціле число:");
            int c = int.Parse(Console.ReadLine());

            // Виклик анонімного методу AverageCalculator
            double average = averageCalculator(a,b,c);
            Console.WriteLine($"Середнє арифметичне значення: {average}");
        }
    }
}
