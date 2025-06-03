using System.Text;

namespace _4Task
{
    /*Створіть клас, який містить інформацію про дату (день, місяць, рік). 
     * За допомогою механізму перевантаження операторів визначте операцію різниці двох дат (результат у вигляді кількості днів між датами),
     * а також операцію збільшення дати на певне кількість днів. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Date date1 = new Date(20, 5, 2025);
            Date date2 = new Date(3, 6, 2025);

            Console.WriteLine($"Розглядаємо наступні дати: {date1} та {date2}");

            int diffDay = date1 - date2;
            Console.WriteLine($"Різниця між датами: {diffDay} днів");

            Date newDate = date2 + 5;
            Console.WriteLine($"Дата після додавання на 5 днів: {newDate}");
        }
    }
    class Date
    {
        public int day;
        public int month;
        public int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        private DateTime ToDateTime()
        {
            return new DateTime(year, month, day);
        }

        // Перевантаження оператора різниці двох дат
        public static int operator -(Date date1, Date date2)
        {
            return Math.Abs((date1.ToDateTime() - date2.ToDateTime()).Days);
        }

        // Перевантаження оператора додавання днів
        public static Date operator +(Date date, int days)
        {
            DateTime newDate = date.ToDateTime().AddDays(days);
            return new Date(newDate.Day, newDate.Month, newDate.Year);
        }

        public override string ToString()
        {
            return $"{day:D2}.{month:D2}.{year}";
        }
    }
}
