using System.Text;

namespace _5Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть клас Calculator, методи якого приймають аргументи та повертають значення типу dynamic.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Enter first number: ");
            dynamic x = ParseNumber(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            dynamic y = ParseNumber(Console.ReadLine());

            Console.WriteLine("Enter action type: +, -, *, / ");
            dynamic action = Console.ReadLine();

            Calculator calculator = new Calculator();
            dynamic result;

            switch (action) 
            {
                case "+":
                    result = calculator.Add(x, y);
                    break;
                case "-":
                    result = calculator.Sub(x, y);
                    break;
                case "*":
                    result = calculator.Mul(x, y);
                    break;
                case "/":
                    result = calculator.Div(x, y);
                    break;
                default:
                    result = "Unknown operation type!";
                    break;
            }
            Console.WriteLine($"{x} {action} {y} = {result}");
            Console.ReadLine();
        }
        static dynamic ParseNumber(string input)
        {
            if (int.TryParse(input, out int i))
                return i;
            if (double.TryParse(input, out double d))
                return d;

            Console.WriteLine("Invalid number, using 0 by default.");
            return 0;
        }
    }

    class Calculator
    {
        public dynamic Add(dynamic x, dynamic y) 
        {
            return x + y;
        }
        public dynamic Sub(dynamic x, dynamic y)
        {
            return x - y;
        }
        public dynamic Mul(dynamic x, dynamic y)
        {
            return x * y;
        }
        public dynamic Div(dynamic x, dynamic y)
        {
            if(y!= 0) return x / y;
            else return "Error Divide on 0";

        }
    }

}
