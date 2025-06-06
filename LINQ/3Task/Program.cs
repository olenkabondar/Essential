using System.Text;

namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Використовуючи динамічні та анонімні типи даних, створіть Англо-Російський словник на 10 слів та виведіть на екран його зміст. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Створюємо список анонімних типів — кожен елемент словника: English + Russian
            var dictionary = new[]
             {
                new { English = "apple", Ukrainian = "яблуко"},
                new { English = "banana", Ukrainian = "банан"},
                new { English = "carrot", Ukrainian = "морква"},
                new { English = "tomato", Ukrainian = "помідор"},
                new { English = "grape", Ukrainian = "виноград"},
                new { English = "cucumber", Ukrainian = "огірок"},
                new { English = "pear", Ukrainian = "груша"},
                new { English = "onion", Ukrainian = "цибуля"},
                new { English = "cherry", Ukrainian = "вишня"},
                new { English = "potatoes", Ukrainian = "картопля"}
            };

            //створюємо динамічну змінну типу нашого словника
            dynamic dict = dictionary;

            Console.WriteLine("Англо-Український словник:");
            foreach (var entry in dict)
            {
                Console.WriteLine($"{entry.English} — {entry.Ukrainian}");
            }
        }
    }
}
