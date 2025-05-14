using System.Text;

namespace _5Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Реалізуйте програму, яка прийматиме від користувача дату народження і виводити кількість днів до наступного дня народження.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть вашу дату народження dd.mm.yyyy :");
            bool isDate = DateTime.TryParse(Console.ReadLine(), out DateTime birthday);
            if (isDate)
            {
                DateTime now = DateTime.Now;
                DateTime nextBirthday = new DateTime(now.Year, birthday.Month, birthday.Day);

                if (nextBirthday < now)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                int days = (nextBirthday - now).Days;
                Console.WriteLine($"До наступного дня народження лишилось {days} днів.");
            }
            else { Console.WriteLine("Невірно введена дата народження!"); }
        }
    }
}
