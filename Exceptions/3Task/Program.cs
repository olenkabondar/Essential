using System.Text;

namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно описати структуру з іменем Price, що містить такі поля:
    • назва товару;
    • назва магазину, де продається товар;
    • вартість товару у гривнях.
    Написати програму, яка виконує такі дії:
    • введення з клавіатури даних до масиву, що складається з двох елементів типу Price (записи мають бути впорядковані в алфавітному порядку
    за назвами магазинів);
    • виведення на екран інформації про товари, що продаються в магазині, назва якого введена з клавіатури (якщо такого магазину немає, вивести виняток).*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int size = 2;
            Price[] prices = new Price[size];

            Console.WriteLine("Введіть дані для 2 продуктів: ");
            for (int i = 0; i < size; i++)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Продукт №{i + 1} ");
                Console.ResetColor();
                Console.Write("Введіть назву товару: ");
                string productName = Console.ReadLine();

                Console.Write("Введіть назву магазину: ");
                string storeName = Console.ReadLine();

                Console.Write($"Введіть ціну продукту {productName}: ");
                decimal priceGRN = decimal.Parse(Console.ReadLine());

                prices[i] = new Price
                {
                    productName = productName,
                    storeName = storeName,
                    priceGRN = priceGRN
                };

            }
            //сортування за магазином
            Array.Sort(prices, (a, b) => string.Compare(a.storeName, b.storeName, StringComparison.OrdinalIgnoreCase));


            // користувацький магазин
            Console.WriteLine();
            Console.WriteLine("Введіть назву магазину, який описати: ");
            string inputStore = Console.ReadLine();
            try
            {
                var findStore = prices.Where(x => string.Equals(x.storeName, inputStore, StringComparison.OrdinalIgnoreCase)).ToList();
                if (!findStore.Any()) { throw new Exception(); }

                Console.WriteLine($"\nТовари у магазині {inputStore}:");
                foreach (var product in findStore)
                {
                    Console.WriteLine($"*{product.productName} ціна: {product.priceGRN} грн");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Магазин {inputStore} не знайдено, помилка {ex.Message}.");
            }
        }
    }
    struct Price
    {
        public string productName;
        public string storeName;
        public decimal priceGRN;
    }
}
