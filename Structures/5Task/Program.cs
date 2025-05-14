using System.Text;

namespace _5Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. 
     * У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Notebook notebook = new Notebook("Блокнот", "Україна", 50);
            notebook.ShowNotebook();
        }
    }
    struct Notebook
    {
        private string model;
        private string maker;
        private decimal price;
        public Notebook(string model, string maker, decimal price)
        {
            this.model = model;
            this.maker = maker;
            this.price = price;
        }
        public void ShowNotebook()
        {
            Console.WriteLine($"Модель товару - {model}, виробник -  {maker}, ціна - {price}.");
        }
    }
}
