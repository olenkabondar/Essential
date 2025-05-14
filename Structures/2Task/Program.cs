using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення.
     * Написати програму, яка виконує такі дії: введення з клавіатури даних до масиву, що складається з восьми елементів типу Train
     * (записи мають бути впорядковані за номерами поїздів); виведення на екран інформації про поїзд, номер якого введено з клавіатури 
     * (якщо таких поїздів немає, вивести відповідне повідомлення). */
    internal class Program
    {
        struct Train
        {
            private string destination;
            private int trainNumber;
            private DateTime timeDeparture;
            public int TrainNumber { get { return trainNumber; } }
            public Train(string destination, int trainNumber, DateTime timeDeparture)
            {
                this.destination = destination;
                this.trainNumber = trainNumber;
                this.timeDeparture = timeDeparture.ToUniversalTime();
            }
            public void ShowInformationTrains()
            {
                Console.WriteLine($"Потяг номер {trainNumber} прямує  до {destination} о {timeDeparture}");
            }
            public static void FindTrainToNumber(int number, Train[] trains)
            {
                bool found = false;
                foreach (Train t in trains)
                {
                    if (number == t.trainNumber)
                    {
                        Console.WriteLine($"Потяг №{t.trainNumber} прямує до {t.destination} о {t.timeDeparture}"); ;
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Потяга номер {number} немає в розкладі!");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Train[] trains = new Train[8]
            {
                new Train("Київ", 1, new DateTime(2025, 5, 14, 10, 00, 0)),
                new Train("Дніпро", 5, new DateTime(2025, 5, 14, 14, 00, 0)),
                new Train("Харків", 3, new DateTime(2025, 5, 14, 12, 15, 0)),
                new Train("Одеса", 4, new DateTime(2025, 5, 14, 13, 15, 0)),
                new Train("Львів", 2, new DateTime(2025, 5, 14, 11, 00, 0)),
                new Train("Львів", 6, new DateTime(2025, 5, 14, 15, 30, 0)),
                new Train("Полтава", 7, new DateTime(2025, 5, 14, 16, 45, 0)),
                new Train("Ужгород", 8, new DateTime(2025, 5, 14, 22, 00, 0))
            };
            Console.WriteLine("Інформація про потяги:");
            foreach (var train in trains)
            {
                train.ShowInformationTrains();
            }
            Console.WriteLine("Інформація про потяги, впорядковані за номерами поїздів:");
            Array.Sort(trains, (a, b) => a.TrainNumber.CompareTo(b.TrainNumber));
            foreach (var train in trains)
            {
                train.ShowInformationTrains();
            }
            Console.WriteLine("Введіть номер потяга для пошуку: ");
            int findNumber = int.Parse(Console.ReadLine());
            Train.FindTrainToNumber(findNumber, trains);
        }
    }
}
