using System.Collections;

namespace _4Task
{
    internal class MyList<T> : IEnumerable<T>
    {
        private T[] list;
        private int count;

        public MyList()
        {
            list = new T[4]; //нехай масив буде розміром 4 елементи
            count = 0;
        }
        // Властивість Count (тільки для читання)
        public int Count
        {
            get { return count; }
        }

        // Індексатор
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                return list[index];
            }
        }


        // Метод додавання елемента
        public void Add(T item)
        {
            if (count == list.Length)
            {
                Array.Resize(ref list, list.Length * 2);
            }
            list[count++] = item;
        }

       
        //реалізуєм цикл foreach
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

