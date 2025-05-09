using System.Text;

namespace _4Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити клас Article, що містить наступні закриті поля:
    • Назва товару;• назва магазину, в якому продається товар;• вартість товару в гривнях. 
    Створити клас Store, який містить закритий масив елементів типу Article.
    Забезпечити такі можливості:
    • висновок інформації про товар за номером за допомогою індексу;
    • висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.
    Написати програму, виведення на екран інформацію про товар.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // описуємо масив товарів
            Article[] products = new Article[]
            {
            new Article("Телефон Samsung", "Розетка", 23658),
            new Article("Телефон", "Ельдорадо", 22999),
            new Article("Планшет", "Розетка", 6999),
            new Article("Планшет", "Moyo", 18000),
            };

            Store store = new Store(products);

            Console.WriteLine("Інформація про товари за індексами:");
            for (int i = 0; i < products.Length; i++)
            {
                store[i].PrintArticleInfo();
                //products[i].PrintArticleInfo();
            }
            // Пошук товару за назвою
            Console.WriteLine("Введіть назву товару для пошуку:");
            string searchName = Console.ReadLine();
            Console.WriteLine("Інформація про знайдені товари: ");
            Article[] findProducts = new Article[] { };
            findProducts = store.FindArticleForNameProduct(searchName);
          
            for (int i = 0; i < findProducts.Length; i++)
            {
                findProducts[i].PrintArticleInfo();
            }
        }
    }
}
