using System.Text;

namespace _3Task14Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            dictionary.Add("apple", "яблуко");
            dictionary.Add("pear", "груша");
            dictionary.Add("melon", "диня");
            dictionary.Add("watermelon", "кавун");

            Console.WriteLine("Перебір колекції за допомогою циклу foreach:");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }

            Console.WriteLine($"Кількість пар у словнику: {dictionary.Count}");
        }
    }
}
