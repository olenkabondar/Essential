using System.Text;

namespace _6Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити статичний клас Calculator, з методами виконання основних арифметичних операцій. 
     * Написати програму, яка виводить на екран основні арифметичні операції.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть перше число: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Додавання: " + Calculator.Add(x, y));
            Console.WriteLine("Віднімання: " + Calculator.Subtract(x, y));
            Console.WriteLine("Множення: " + Calculator.Multiply(x, y));
            Console.WriteLine("Ділення: " + Calculator.Divide(x, y));
        }
    }
}
