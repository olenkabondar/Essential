using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть клас MyList. 
     * Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу List. 
     * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, 
     * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyList<string> myList = new MyList<string>();
            Console.WriteLine($"Початкова кількість елеменів: {myList.Count}");

            myList.Add("Привіт");
            myList.Add("Це");
            myList.Add("Олена");
            myList.Add("Бондар");
            myList.Add("Як");
            myList.Add("ваші");
            myList.Add("справи?");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine($"Загальна кількість елементів: {myList.Count}");

            //для 4 завдання
            //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
            //Створіть метод, що розширює: public static T[] GetArray(this MyList list) Застосуйте розширюючий метод до екземпляра типу MyList,
            //розробленого в домашньому завданні 2 для даного уроку.Виведіть на екран значення елементів масиву, який повернув метод GetArray(),
            //що розширює метод.
            MyList<int> myListInt = new MyList<int>();
            myListInt.Add(1);
            myListInt.Add(2);
            myListInt.Add(3);
            myListInt.Add(4);
            myListInt.Add(4);
            myListInt.Add(5);

            int[] array = myListInt.GetArray();
            
            Console.WriteLine("Масив з MyListInt:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Загальна кількість елементів: {myListInt.Count}");
        }
    }
}
