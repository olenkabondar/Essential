using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: Створити клас AbstractHandler. У тілі класу створити методи void Open(), void Create(), void Change(), void Save(). 
    Створити похідні класи XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler. 
    Написати програму, яка виконуватиме визначення документа і для кожного формату мають бути методи відкриття, 
    створення, редагування, збереження певного формату документа.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Виберіть тим документу - xml, txt або doc:");
            string type = Console.ReadLine().ToLower();
            AbstractHandler handler;
            if(type == "xml")
            {
                handler = new XMLHandler();
            }
            else if(type == "txt")
                    {
                handler = new TXTHandler();
            }
            else if(type == "doc")
            {
                handler = new DOCHandler();
            }
            else
            {
                Console.WriteLine("Не вірно введено тип документу!");
            }
        }
    }
}
