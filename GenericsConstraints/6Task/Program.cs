using System.Collections;
using System.Text;
using System.Xml.Linq;

namespace _6Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
     * У колекцію ArrayList, через виклик методу Add додайте елементи структурного та посилального типу, переберіть цю колекцію за допомогою циклу for. 
     * З якою проблемою ви зіткнулися?*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(true);
            arrayList.Add(DateTime.Now);
            arrayList.Add(new string[2] { "first", "second" });
            arrayList.Add("Olena");
            arrayList.Add(new Surname("Bondar"));
            for (int i = 0; i < arrayList.Count; i++) 
            {
                object item = arrayList[i];

                Console.WriteLine($"[{i}]: {item} (Тип: {item.GetType().Name})");
            }
            //Колекція ArrayList зберігає елементи як object, тому при додаванні структурних типів (наприклад, int, double)
            //вони автоматично "упаковуються" (boxing).
        }
    }
    public class Surname
    {
        public string surName { get; set; }
        public Surname(string surname) 
        {
            surName = surname;
        }
        public override string ToString()
        {
            return $"Person: {surName}";
        }
    }
}
