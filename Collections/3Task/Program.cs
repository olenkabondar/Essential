using System.Collections.Generic;
using System.Text;

namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть колекцію MyDictionary. 
     * Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу Dictionary. 
     * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, 
     * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. 
     * Реалізуйте можливість перебору елементів колекції у циклі наперед.*/
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
    
