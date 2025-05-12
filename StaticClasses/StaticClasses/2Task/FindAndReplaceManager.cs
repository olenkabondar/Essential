using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    static class FindAndReplaceManager
    {
        private static Book book;

        public static void SetBook(Book _book)
        {
            book = _book;
        }

        public static void FindNext(string str)
        {
            if (book != null)
            {
                book.FindNext(str);
            }
            else
            {
                Console.WriteLine("Книга пуста.");
            }
        }
    }
}
