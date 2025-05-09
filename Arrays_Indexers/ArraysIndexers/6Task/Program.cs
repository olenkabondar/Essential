using System.Text;

namespace _6Task
{
    //реалізація українсько-англійського словника з масивами
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Створюємо українсько-англійський словник про фрукти:");
            Console.ResetColor();
            Translator[] data = new Translator[]
                {
                    new Translator("банан", "banana"),
                    new Translator("кавун", "watermelon"),
                    new Translator("груша", "pear"),
                    new Translator("яблуко", "apple"),
                    new Translator("вишня", "cherry"),
                    new Translator("полуниця", "strawberry"),
                    new Translator("абрикос", "apricot"),
                    new Translator("диня", "melon"),
                };

            MyDictionary dictionary = new MyDictionary(data);

            dictionary.ShowAllDictionary();

            Console.WriteLine("Введіть українське слово для перекладу:");
            string inputUkr = Console.ReadLine();

            Console.WriteLine($"{inputUkr} - {dictionary[inputUkr]}");

            Console.WriteLine("Введіть числовий індексом для пошуку:");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                Translator result = dictionary[index];
                if (result != null)
                {
                    result.ShowTranslateWord();
                }
            }
            else
            {
                Console.WriteLine("Це не числовий індекс.");
            }
        }
    }
}
