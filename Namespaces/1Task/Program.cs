using _3Task14Lesson;
using System.Text;

namespace _1Task
{
    /*Використовуючи приклад виконаного домашнього завдання 3 з 14 уроку, реалізуйте можливість підключення вашого простору імен
     * та роботи з MyDictionary аналогічно екземпляру класу Dictionary.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var myDict = new MyDictionary<string, string>();

            myDict.Add("cherry", "вишня");
            myDict.Add("strawberry", "полуниця");
            myDict.Add("blueberry", "чорниця");

            Console.WriteLine($" Кількість елементів: {myDict.Count}");

            // Цикл foreach
            Console.WriteLine("\n Усі пари ключ-значення:");
            foreach (var pair in myDict)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }

            Console.WriteLine("\n Доступ за ключем:");
            // Доступ за ключем
            Console.WriteLine("cherry = " + myDict["cherry"]);
            Console.WriteLine("dragonfruit = " + myDict["dragonfruit"]); // ключ не існує

            
        }
    }
}
