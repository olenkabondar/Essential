using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _3Task
{
    public class MyDictionary<TKey, TValue> : IEnumerable
    {
        private List<TKey> keys = new List<TKey>();
        private List<TValue> values = new List<TValue>();

        // Додавання нової пари ключ-значення
        public void Add(TKey key, TValue value)
        {
            if (keys.Contains(key))
                Console.WriteLine($"Такий ключ {key} вже існує.");
            else
            {
                keys.Add(key);
                values.Add(value);
            }
        }

        // Індексатор для отримання значення за ключем
        public TValue this[TKey key]
        {
            get
            {
                int index = keys.IndexOf(key);
                if (index == -1)
                {
                    Console.WriteLine("Ключ не знайдено.");
                    return default(TValue);
                }
                else return values[index];
            }
        }

        // Властивість тільки для читання: кількість елементів
        public int Count
        {
            get { return keys.Count; }
        }

        //реалізація циклу foreach
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
