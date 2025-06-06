using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Уявіть, що ви пишете програму для Автостанції і вам необхідно створити просту колекцію автомобілів з такими даними: 
     * марка автомобіля, модель, рік випуску, колір. А також другу колекцію з моделлю автомобіля, ім'ям покупця та його номером телефону. 
     * Використовуючи найпростіший запит LINQ, виведіть на екран інформацію про покупця одного з автомобілів і повну характеристику придбаної ним моделі.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            List<Car> cars = new List<Car>
            {
                new Car { CarBrand = "Wolksvagen", Model = "Golf", Year = 2020, Color = "Blue" },
                new Car { CarBrand = "BMW", Model = "X5", Year = 2025, Color = "Black" },
                new Car { CarBrand = "Tesla", Model = "Tesla", Year = 2023, Color = "White" },
                new Car { CarBrand = "Audi", Model = "Q5", Year = 2022, Color = "Red" },
            };

            // Колекція покупців
            List<Buyer> buyers = new List<Buyer>
            {
                new Buyer { CarModel = "Audi", NameBuyer = "Olena Bondar", PhoneBuyer = "0352645189" },
                new Buyer { CarModel = "Wolksvagen", NameBuyer = "Petro Petrov", PhoneBuyer = "0465982315" },
                new Buyer { CarModel = "BMW", NameBuyer = "Olena Bondar", PhoneBuyer = "0352645189" }
            };

            // LINQ-запит для знаходження інформації про покупців і відповідних автомобілів
            var query = from car in cars
                        join buyer in buyers on car.CarBrand equals buyer.CarModel
                        select new
                        {
                            buyer.NameBuyer,
                            buyer.PhoneBuyer,
                            car.CarBrand,
                            car.Model,
                            car.Year,
                            car.Color
                        };

            //// Виведення результату всіх покупців
            //foreach (var result in query)
            //{
            //    Console.WriteLine($"Покупець: {result.NameBuyer}");
            //    Console.WriteLine($"Телефон: {result.PhoneBuyer}");
            //    Console.WriteLine($"Автомобіль: {result.CarBrand} {result.Model}, {result.Year} року, колір: {result.Color}");
            //    Console.WriteLine(new string('-', 50));
            //}

            var avtoBondar = from b in query where b.NameBuyer == "Olena Bondar" select b;
            Console.WriteLine("Покупець: Olena Bondar");
            foreach (var result in avtoBondar)
            {
                Console.WriteLine($"Автомобіль: {result.CarBrand} {result.Model}, {result.Year} року, колір: {result.Color}");
            }
        }
    }

    public class Car
    {
        public string CarBrand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    public class Buyer
    {
        public string CarModel { get; set; }
        public string NameBuyer { get; set; }
        public string PhoneBuyer { get; set; }
    }
}
