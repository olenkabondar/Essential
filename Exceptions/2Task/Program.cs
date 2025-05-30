using System.Text;

namespace _2Task
{
    /*Потрібно описати структуру з ім'ям Worker, що містить такі поля:
    • прізвище та ініціали працівника;
    • назва займаної посади;
    • рік надходження працювати.
    Написати програму, яка виконує такі дії:
    • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
    • якщо значення року введено не у відповідному форматі видає виняток;
    • виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int size = 5;
            Worker[] workers = new Worker[size];

            Console.WriteLine("Введіть дані для 5 працівників: ");
            for (int i = 0; i < size; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Працівник №{i + 1} ");
                Console.ResetColor();
                Console.Write("Введіть прізвище та ініціали: ");
                string name = Console.ReadLine();

                Console.Write("Введіть посаду: ");
                string position = Console.ReadLine();

                int year = 0;

                while (true)
                {
                    Console.Write("Введіть рік надходження на роботу: ");
                    //string input = Console.ReadLine();
                    try
                    {
                        year = int.Parse(Console.ReadLine());
                        if (year > DateTime.Now.Year)
                            throw new Exception("Рік не може бути більшим за поточний " + DateTime.Now.Year);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Не вірно введено рік початку роботи: " + ex.Message);
                    }
                }
                workers[i] = new Worker
                {
                    fullName = name,
                    jobPosition = position,
                    yearEntry = year
                };
            }

            // Сортування за прізвищем
            Array.Sort(workers, (a, b) => string.Compare(a.fullName, b.fullName, StringComparison.OrdinalIgnoreCase));

            // Введення користувачем мінімального стажу
            Console.WriteLine();
            Console.Write("Введіть мінімальний стаж (в роках): ");
            int minExperience;
            while (!int.TryParse(Console.ReadLine(), out minExperience) || minExperience < 0)
            {
                Console.Write("Некоректне значення. Повторіть спробу: ");
            }

            // Виведення працівників із більшим стажем
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Працівники зі стажем більше {minExperience} років:");
            Console.ResetColor();

            bool found = false;

            foreach (var worker in workers)
            {
                int experience = worker.GetExperience();
                if (experience > minExperience)
                {
                    Console.WriteLine($"{worker.fullName} ({worker.jobPosition}), Стаж: {experience} років");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Немає працівників з таким стажем.");
            }
        }
    }
    struct Worker
    {
        public string fullName;
        public string jobPosition;
        public int yearEntry;
        public int GetExperience()
        {
            return DateTime.Now.Year - yearEntry;
        }
    }
}
