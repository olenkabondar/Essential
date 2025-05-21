using System.Text;

namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть клас Dictionary.
     * Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу Dictionary
     * із простору імен System.Collections.Generic. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання пар елементів,
     * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості пар елементів.*/
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

            Console.WriteLine($"Кількість пар у словнику: {dictionary.Count}");

            Console.WriteLine($"Переклад слова 'pear': {dictionary["pear"]}");
            Console.WriteLine($"Переклад слова 'watermelon': {dictionary["watermelon"]}");

            // Розкоментуйте рядок нижче, щоб побачити обробку винятку
            //Console.WriteLine(dictionary["cherry"]);

            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "один");
            myDictionary.Add(2, "два");
            myDictionary.Add(3, "три");

            Console.WriteLine($"Кількість пар у словнику: {myDictionary.Count}");

            Console.WriteLine($"За ключем '1': {myDictionary[1]}");
            Console.WriteLine($"За ключем '3': {myDictionary[3]}");
            //Console.WriteLine($"За ключем '6': {myDictionary[6]}"); //обробкa винятку
        }
    }
}
