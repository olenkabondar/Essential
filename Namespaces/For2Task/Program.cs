using _2Task;

namespace For2Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyNewClass myNewClass = new MyNewClass();   
            myNewClass.ShowMessage();
            Console.ReadLine();
        }
    }

    class MyNewClass : MyClass
    {

    }
}
