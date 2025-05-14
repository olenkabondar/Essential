using System.Text;

namespace _3Task
{
    /*Створіть клас MyClass і структуру MyStruct, які містять поля public string change. 
     * У класі Program створіть два методи: static void ClassTaker(MyClass myClass), який надає полю change екземпляра myClass значення «змінено». 
     * static void StruktTaker(MyStruct myStruct), який надає полю change екземпляра myStruct значення «змінено». 
     * Продемонструйте різницю у використанні класів та структур, створивши у методі Main() екземпляри структури та класу. 
     * Змініть значення полів екземплярів на «не змінено», а потім викличте методи ClassTaker і StruktTaker. 
     * Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            MyClass classInstance = new MyClass();
            MyStruct structInstance = new MyStruct();

            classInstance.change = "не змінено";
            structInstance.change = "не змінено";

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("До виклику методів:");
            Console.ResetColor();
            Console.WriteLine($"Клас: змінна <change> = {classInstance.change}");
            Console.WriteLine($"Структура: змінна <change> = {structInstance.change}");

            ClassTaker(classInstance);
            StruktTaker(structInstance);


            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nПісля виклику методів:");
            Console.ResetColor();
            Console.WriteLine($"Клас: змінна <change> = {classInstance.change}");
            Console.WriteLine($"Структура: змінна <change> = {structInstance.change}");

            Console.WriteLine("Клас змінився, бо передається за посиланням.");
            Console.WriteLine("Структура залишилась незмінною, бо передається її копія.");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВиклик методу static string StruktTakerReturn(MyStruct myStruct):");
            Console.ResetColor();
            string changeStr = StruktTakerReturn(structInstance);
            Console.WriteLine($"Структура: змінна <change> return = {changeStr}");
            Console.WriteLine("Метод дійсно повертає 'змінено', але оригінальна структура не змінюється, бо була передана копія.");

        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "змінено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "змінено";
        }
        static string StruktTakerReturn(MyStruct myStruct)
        {
            return myStruct.change = "змінено";
        }
    }
    public class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
}
