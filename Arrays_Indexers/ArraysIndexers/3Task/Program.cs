using System.Text;

namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного розміру з можливістю зміни числа рядків і стовпців. 
     * Написати програму, яка виводить на екран матрицю і похідні від неї матриці різних порядків.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //задаємо розміри матриці 2 на 3
            MyMatrix matrix = new MyMatrix(2, 3);
            matrix.AddRandomDataMatrix();

            Console.WriteLine("Початкова матриця 2 на 3:");
            matrix.PrintDataMatrix();

            Console.WriteLine("Введіть кількість рядків матриці: ");
            int inputRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість стовпців матриці: ");
            int inputCols = int.Parse(Console.ReadLine());

            Console.WriteLine($"Зміна розміру матриці {inputRows} на {inputCols}: ");
            //matrix = new MyMatrix(inputRows, inputCols);
            //matrix.AddRandomDataMatrix();
            //matrix.PrintDataMatrix();
            matrix.ResizeDataMatrix(inputRows, inputCols);
            matrix.PrintDataMatrix(); //дозаповнюється 0
        }
    }
}
