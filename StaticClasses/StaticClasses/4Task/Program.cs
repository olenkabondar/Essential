using System.Text;

namespace _4Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int[] numbers = { 5, 2, 8, 9, 1, 3, 13, 56, 4, 8 };

            Console.WriteLine("Початковий масив:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            numbers.SortAscending();
            Console.WriteLine("\nВідсортований масив за зростанням:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }      
    }

    static class ArrayExtensions
    {
        // Розширюючий метод для масиву int[] який сортує елементи масиву за зростанням
        public static void SortAscending(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
