namespace _2Task
{
    public class MyList<T>
    {
        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[5]; // нехай початковий розмір масиву буде 5
            count = 0;
        }

        // Властивість для отримання кількості елементів
        public int Count
        {
            get { return count; }
        }

        // Метод додавання елемента
        public void Add(T item)
        {
            if (count == items.Length)
                Array.Resize(ref items, items.Length == 0 ? 5 : items.Length * 2);

            items[count++] = item;
        }

        // Індексатор
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    Console.WriteLine("Заданий індекс поза межами списку.");
                return items[index];
            }
        }
    }

    //для завдання 4
    public static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i];
            }
            return result;
        }
    }
}
