using System.Collections;

namespace _2Task
{
    internal class MyList : IEnumerable
    {
        private string[] list;
        private int count;

        public MyList()
        {
            list = new string[4]; //нехай масив буде розміром 4 елементи
            count = 0;
        }
        // Властивість Count (тільки для читання)
        public int Count
        {
            get { return count; }
        }

        // Індексатор
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                return list[index];
            }
        }


        // Метод додавання елемента
        public void Add(string item)
        {
            if (count == list.Length)
            {
                Array.Resize(ref list, list.Length * 2);
            }
            list[count++] = item;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator(this);
        }

        //внутрішній клас, що реалізує цикл foreach
        private class MyListEnumerator : IEnumerator
        {
            private MyList list;
            private int position = -1;

            public MyListEnumerator(MyList list)
            {
                this.list = list;
            }

            public bool MoveNext()
            {
                position++;
                return position < list.count;
            }

            public void Reset()
            {
                position = -1;
            }

            public object Current
            {
                get
                {
                    if (position < 0 || position >= list.count)
                    { return null; }
                    else return list[position];
                }
            }
        }
    }
}
