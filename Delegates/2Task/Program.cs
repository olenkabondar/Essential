using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть чотири лямбда оператора для виконання арифметичних дій: (Add – додавання, Sub – віднімання, Mul – множення, Div – поділ). 
     * Кожен лямбда оператор повинен приймати два аргументи та повертати результат обчислення. Лямбда оператор поділу повинен перевірити поділ на нуль. 
     * Написати програму, яка виконуватиме арифметичні дії, вказані користувачем. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (x, y) => x + y;
            Func<int, int, int> Sub = (x, y) => x - y;
            Func<int, int, int> Mul = (x, y) => x * y;
            Func<int, int, double > Div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("На нуль ділить не можна!");
                    return double.NaN;
                }
                else return (double) x / y;
            };

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть перше ціле число:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге ціле число:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Виберіть операцію з запропонованих: +, -, *, /");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {x} + {y} = { Add (x,y) }");
                    break;

                case "-":
                    Console.WriteLine($"Результат: {x} - {y} = { Sub (x, y) }");
                    break;

                case "*":
                    Console.WriteLine($"Результат: {x} * {y} = { Mul (x, y) }");
                    break;

                case "/":
                    Console.WriteLine($"Результат: {x} / {y} = { Div (x, y) }");
                    break;

                default:
                    Console.WriteLine("Не вірно введена операція.");
                    break;
            }
        }
    }
}
