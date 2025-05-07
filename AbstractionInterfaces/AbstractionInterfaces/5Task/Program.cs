using System.Text;

namespace _5Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Змінити приклад першого уроку (робота з документом) і створити загальний абстрактний клас для всіх частин документа.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Document document = new Document();
            document.Title = "Це заголовок документу.";
            document.Body = "Це тіло документу.";
            document.Footer = "Це колонтитут документу.";
            document.Show();
        }
    }
}
