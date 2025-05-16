using System.Text;

namespace _3Task
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть анонімний метод, який приймає як аргумент масив делегатів і повертає середнє арифметичне значення значень методів, 
     * повідомлених з делегатами в масиві. Методи, повідомлені з делегатами з масиву, повертають випадкове значення типу int. 
     */
    internal class Program
    {
        public delegate int RandomIntDelegate();
        public delegate double AverageCalculator(RandomIntDelegate[] array);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Random random = new Random();

            RandomIntDelegate[] generatorInt = new RandomIntDelegate[4];

            for (int i = 0; i < generatorInt.Length; i++)
            {
                // Описуємо анонімний метод, що повертає випадкове число               
                generatorInt[i] = delegate
                {
                    return random.Next(0, 100);
                };
            }

            // Описуємо анонімний метод для обчислення середнього арифметичного значення
            AverageCalculator averageCalculator = delegate (RandomIntDelegate[] array)
            {
                int sum = 0;
                foreach (var generator in array)
                {
                    int value = generator();//викликає делегат RandomIntDelegate
                    Console.WriteLine($"Згенеровано число: {value}");
                    sum += value;
                }

                return (double)sum / array.Length;
            };

            // Виклик анонімного методу AverageCalculator
            double average = averageCalculator(generatorInt);
            Console.WriteLine($"Середнє арифметичне значення: {average}");
        }
    }
}
