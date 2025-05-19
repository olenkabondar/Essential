
namespace _4Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть метод, що розширює: public static T[ ] GetArray(this MyList list) Застосуйте розширюючий метод до екземпляра типу MyList,
     * розробленого в домашньому завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який повернув метод GetArray(), 
     * що розширює метод.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList   
            Console.WriteLine("Hello, World!");
        }

        public static T[] GetArray(this MyList list)
        { 
            return list.ToArray();
        }
    }
}
