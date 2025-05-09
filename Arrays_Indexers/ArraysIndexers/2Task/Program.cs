using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити масив розмірністю N елементів, заповнити його довільними цілими значеннями. 
     * Вивести найбільше значення масиву, найменше значення масиву, загальну суму елементів, середнє арифметичне всіх елементів, 
     * вивести всі непарні значення.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Введіть розмір масиву (N): ");
            int size = int.Parse(Console.ReadLine());

            if (size != 0)
            {
                int[] array = new int[size];
                Random random = new Random();

                Console.WriteLine("Заповнюємо масив довільними числами від 0 до 100:");
                for (int i = 0; i < size; i++)
                {
                    array[i] = random.Next(0, 100);
                    Console.Write(array[i] + " ");
                }

                int max = array.Max();
                int min = array.Min();
                int sum = array.Sum();
                double avg = array.Average();

                Console.WriteLine();
                Console.WriteLine($"Найбільше значення масиву: {max}");
                Console.WriteLine($"Найменше значення масиву: {min}");
                Console.WriteLine($"Сума всіх елементів масиву: {sum}");
                Console.WriteLine($"Середнє арифметичне елементів масиву: {avg:F2}");

                Console.WriteLine("Непарні значення масиву:");
                foreach (int num in array)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            else { Console.WriteLine("Розмір масиву не може бути 0!"); }
        }
    }
}
