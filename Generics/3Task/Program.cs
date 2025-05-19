using System.Text;

namespace _3Task
{
    /*Створіть проект Console Application, де реалізуйте типізований клас "Чарівний мішок". 
     * Чарівність полягає в тому, що подарунок сам з'являється у мішку та залежить від того, хто намагається відкрити мішок. 
     * Причому подарунок для однієї істоти може з'явитись лише 1 раз на день. Використовуйте обмеження типу - інтерфейс із властивістю, 
     * що зберігає тип істоти, яка намагається отримати подарунок із мішка.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var cat = new Cat ("Мявчик");
            var dog = new Dog ("Гавчик");

            var bagForCat = new MagicBag<Cat>();
            var bagForDog = new MagicBag<Dog>();

            Console.WriteLine(bagForCat.GetGift(cat)); // перше отримання для котика
            Console.WriteLine(bagForCat.GetGift(cat)); // спроба вдруге в той самий день

            Console.WriteLine(bagForDog.GetGift(dog)); // подарунок для собачки
            Console.WriteLine(bagForDog.GetGift(dog)); // спроба вдруге в той самий день
        }
    }
    public interface ISomeone
    {
        string Type { get; }
        string Name { get; }
        DateTime LastGiftDate { get; set; }
    }
    public class Cat : ISomeone 
    {
        public string Name { get; set; }
        public string Type => "Cat";
        public DateTime LastGiftDate { get; set; }

        public Cat(string name)
        {
            Name = name;
            LastGiftDate = DateTime.MinValue; // початково немає подарунка
        }
    }
    public class Dog : ISomeone
    {
        public string Name { get; set; }
        public string Type => "Dog";

        public  DateTime LastGiftDate { get; set; }

        public Dog(string name)
        {
            Name = name;

            LastGiftDate = DateTime.MinValue; // початково немає подарунка
        }
    }
    public class MagicBag<T> where T : ISomeone
    {
        private Random random = new Random();
        public string GetGift(T creature)
        {
            if (creature.LastGiftDate.Date == DateTime.Now.Date)
            {
                return $"Сьогодні {creature.Name} вже отримав подарунок!";
            }

            string gift = GenerateGiftForCreature(creature);
            creature.LastGiftDate = DateTime.Now;
            return $"{creature.Name} отримав подарунок: {gift}.";
        }

        private string GenerateGiftForCreature(T creature)
        {
            if (creature.Type == "Cat")
            {
                string[] gifts = { "Молоко", "Мишка", "Риба", "Клубок" };
                return gifts[random.Next(gifts.Length)];
            }
            else if (creature.Type == "Dog")
            {
                string[] gifts = { "Кісточка", "Риба", "Мячик"};
                return gifts[random.Next(gifts.Length)];
            }
            else
            {
                return "Невідомий подарунок.";
            }
        }
    }

}
