namespace _3Task
{
    internal class Book
    {
        public Book()
        {
            notes = new Notes();
        }

        private Notes notes;
        public Notes GetNotes()
        {
            return notes;
        }
        public class Notes
        {
            private int[] pages = new int[100];        // масив сторінок розміром 100
            private string[] addNotes = new string[100];  // масив нотатокм розміром 100
            private int count = 0;                     // кількість доданих нотаток

            public void AddNote(int page, string text)
            {
                if (count < pages.Length)
                {
                    pages[count] = page;
                    addNotes[count] = text;
                    count++;
                    Console.WriteLine($"Нотатку {text} додано.");
                }
                else
                {
                    Console.WriteLine("Досягнуто межу кількості сторінок.");
                }
            }

            public void ShowAllNotes()
            {
                if (count == 0)
                {
                    Console.WriteLine("Немає нотаток.");
                }
                else
                {
                    Console.WriteLine("Список всіх нотаток:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Сторінка " + pages[i] + ": " + addNotes[i]);
                    }
                }
            }
        }
    }
}
