using System.Reflection;
using System.Text;

namespace _2Task
{
    /*
     Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть статичний клас із методом void Print (string stroka, int color), який виводить на екран рядок заданим кольором. 
    Використовуючи перелік, створіть набір кольорів, доступних користувачеві. Введення рядка та вибір кольору надайте користувачеві.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть рядок для виведення: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nОберіть номер кольору з доступних:");
            foreach (var color in Enum.GetValues(typeof(MyColor)))
            {
                Console.WriteLine($"{(int)color} — {color}");
            }

            if (int.TryParse(Console.ReadLine(), out int colorNumber))
            {
                MyPrint.Print(input, colorNumber);
            }
            else
            {
                Console.WriteLine("Некоректне введення кольору.");
            }
        }
    }
    static class MyPrint 
    {
        public static void Print(string stroka, int color)
        {

            if (Enum.IsDefined(typeof(ConsoleColor), color))
            {
                Console.ForegroundColor = (ConsoleColor)color;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Невідомий колір, використовується білий.");
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
    enum MyColor
    {
        //ConsoleColor.Gray      7
        //ConsoleColor.Blue      9
        //ConsoleColor.Green     10
        //ConsoleColor.Cyan      11
        //ConsoleColor.Red       12
        //ConsoleColor.Magenta   13
        //ConsoleColor.Yellow    14
        Gray =  7,
        Blue = 9,
        Green = 10,
        Cyan = 11,
        Red = 12,
        Magenta = 13,
        Yellow =  14
    }

}
