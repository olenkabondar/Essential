using System.Text;

namespace _4Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть клас ArrayList. 
     * Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу 
     * ArrayList із простору імен System.Collections. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            ArrayList list = new ArrayList();

            list.Add(123);
            list.Add("Привіт");
            list.Add("Я - Олена!");
            list.Add(true);
            list.Add("Ще одне значення");
            list.Add("36,6");

            Console.WriteLine("Елементи списку:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"[{i}]: {list[i]}");
            }

            Console.WriteLine($"Всього елементів: {list.Count}");
            Console.WriteLine($"Елемент за індексом 5: {list[5]}");
            list.Clear();
            Console.WriteLine($"Всього елементів після очищення: {list.Count}");
        }
    }
}
