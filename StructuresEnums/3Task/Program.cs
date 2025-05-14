using System.Text;

namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть перелік, який містить посади співробітників як імена констант. 
     * Надайте кожній константі значення, що задає кількість годин, які повинен відпрацювати співробітник протягом місяця. 
     * Створіть клас Accountant з методом bool AskForBonus (Post worker, int hours), що відображатиме давати співробітнику премію. 
     * Якщо співробітник відпрацював більше годин на місяць, то йому належить премія.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Доступні посади:");
            foreach (var post in Enum.GetValues(typeof(Post)))
            {
                Console.WriteLine($"{(int)post} годин — {post}");
            }

            Console.WriteLine("\nВведіть назву посади з описаних вище: ");
            string inputPost = Console.ReadLine();

            if (!Enum.TryParse(inputPost, out Post selectedPost))
            {
                Console.WriteLine("Невірна посада.");
            }
            else
            {
                Console.WriteLine("Введіть кількість відпрацьованих годин: ");
                int actualHours = int.Parse(Console.ReadLine());

                Accountant accountant = new Accountant();

                if (accountant.AskForBonus(selectedPost, actualHours))
                {
                    Console.WriteLine("Співробітнику належить премія!");
                }
                else
                {
                    Console.WriteLine("Премія не передбачена.");
                }
            }
        }
    }
}
