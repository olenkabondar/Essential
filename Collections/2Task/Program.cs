using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть колекцію MyList. 
     * Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу List. 
     * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, 
     * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів.
     * Реалізуйте можливість перебору елементів колекції у циклі наперед.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyList list = new MyList();
            list.Add("Hello!");
            list.Add("My name is Olena.");
            list.Add("I study programing.");
            list.Add("Good Bye!");

            Console.WriteLine($"Кількість елементів: {list.Count}");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Перебір за допомогою for:");
            Console.ResetColor();

            //виведемо з циклом for
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Елемент №{i}: {list[i]}");
            }

            //виведемо з циклом foreach
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Перебір за допомогою foreach:");
            Console.ResetColor();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
