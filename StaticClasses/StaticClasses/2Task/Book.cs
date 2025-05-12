namespace _2Task
{
    internal class Book
    {
        private string content;
        private int currentIndex = 0;

        public Book(string content)
        {
            this.content = content;
        }

        public void FindNext(string str)
        {
            int foundIndex = content.IndexOf(str, currentIndex, StringComparison.OrdinalIgnoreCase);

            if (foundIndex != -1)
            {
                Console.WriteLine($"Знайдено {str} на позиції {foundIndex}");
                currentIndex = foundIndex + str.Length;
            }
            else
            {
                Console.WriteLine($"Слово {str} не знайдено в тексті.");
                currentIndex = 0; // починаємо з початку
            }
        }
    }
}
