using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть клас CarCollection. 
     * Реалізуйте у найпростішому наближенні можливість використання екземпляра для створення парку машин. 
     * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання машин з назвою машини і року її випуску,
     * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів.
     * Створіть спосіб видалення всіх машин автопарку.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CarCollection carCollection = new CarCollection();
            carCollection.AddCar("Volkswagen Golf", 2020);
            carCollection.AddCar("Honda Accord", 2015);
            carCollection.AddCar("BMW X5", 2024);
            carCollection.AddCar("Audi Q5", 2023);

            Console.WriteLine($"У парку наразі є {carCollection.Count} машин:");

            for (int i = 0; i < carCollection.Count; i++)
            {
                Console.WriteLine(carCollection[i].ToString());
            }
            // Console.WriteLine(carCollection[5].ToString()); виклик невідомого індексу

            Console.WriteLine("\nВиклик методу видалення всіх машин.");
            carCollection.Clear();

            Console.WriteLine($"У парку після очищення: {carCollection.Count} машин");
        }
    }
}
