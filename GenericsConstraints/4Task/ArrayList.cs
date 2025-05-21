
namespace _4Task
{
    internal class ArrayList
    {
        private object[] items;
        private int count;

        public ArrayList()
        {
            items = new object[3]; // початковий розмір
            count = 0;
        }

        // Метод додавання елемента
        public void Add(object item)
        {
            if (count == items.Length)
            {
                // Збільшуємо масив удвічі при потребі
                Resize();
            }
            items[count] = item;
            count++;
        }

        // Індексатор для доступу до елементів
        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return items[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < count)
                    items[index] = value;
            }
        }

        // Властивість для кількості елементів
        public int Count
        {
            get { return count; }
        }

        // Метод розширення масиву
        private void Resize()
        {
            int newSize = items.Length * 2;
            object[] newItems = new object[newSize];

            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                items[i] = null;
            }
            count = 0;
        }
    }
}
