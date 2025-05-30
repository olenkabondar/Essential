using System.Text;

namespace _5Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть клас Calculator. 
     * У тілі класу створіть чотири методи для арифметичних дій: Add – додавання, Sub – віднімання, Mul – множення, Div – розподіл. 
     * Метод поділу повинен перевірити поділ на нуль, якщо перевірка не проходить, згенерувати виняток. 
     * Користувач вводить значення, над якими хоче зробити операцію та вибрати саму операцію. У разі виникнення помилок повинні викидатися винятки.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                Console.WriteLine("Введіть перше число: ");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введіть друге число: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Виберіть операцію +,-,*,/ : ");
                string operation = Console.ReadLine();

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = calculator.Add(a, b);
                        break;
                    case "-":
                        result = calculator.Sub(a, b);
                        break;
                    case "*":
                        result = calculator.Mul(a, b);
                        break;
                    case "/":
                        result = calculator.Div(a, b);
                        break;
                    default:
                        throw new InvalidOperationException("Невідома операція.");
                }
                Console.WriteLine($"Результат: {a} {operation} {b} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: невірний формат числа.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}
