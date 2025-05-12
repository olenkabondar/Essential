using System.Text;

namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes, який дозволить зберігати нотатки читача.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Book myBook = new Book();

            Book.Notes myNotes = myBook.GetNotes();
            myNotes.AddNote(5, " -привіт- на 5 сторінку");
            myNotes.AddNote(10, " -як справи- на 10 сторінку");
            myNotes.AddNote(15, " -до побачення- на 15 сторінку");

            myNotes.ShowAllNotes();
        }
    }
}
