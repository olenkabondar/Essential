using System.Text;

namespace _4Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…} 
     * Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому завданні 2 для даного уроку. 
     * Виведіть на екран значення елементів масиву, який повернув метод GetArray(), що розширює метод.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyList<string> list = new MyList<string>();
            list.Add("Hello!");
            list.Add("My name is Olena.");
            list.Add("I study programing.");
            list.Add("Good Bye!");

            Console.WriteLine($"Кількість елементів: {list.Count}");

            // Використання розширюючого методу
            string[] array = list.GetArray();

            Console.WriteLine("Перебір за допомогою foreach:");           
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
