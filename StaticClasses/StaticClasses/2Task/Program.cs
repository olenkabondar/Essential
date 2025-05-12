using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str) 
     * для пошуку за книгою з прикладу уроку 005_Book. При виклику цього методу проводиться послідовний пошук рядка в книзі.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string bookText = "Це приклад тексту книги. Ми любимо понеділок. Програмування найцікавіше починати в понеділок.";
            Book myBook = new Book(bookText);

            FindAndReplaceManager.SetBook(myBook);
            FindAndReplaceManager.FindNext("Понеділок");
            FindAndReplaceManager.FindNext("Понеділок");
        }
    }
}
