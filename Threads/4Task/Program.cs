using System.Text;

namespace _4Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Напишіть програму, в якій метод викликатиметься рекурсивно. 
     * Кожен новий виклик методу виконується окремому потоці.*/
    internal class Program
    {
        public static int maxDepth = 3; // нехай глибина рекурсії методу буде 3 максимально
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;           
            Recursive(0, maxDepth);
        }
        static void Recursive(int currentDepth, int maxDepth)
        {
            Console.WriteLine($"[Потік {Thread.CurrentThread.ManagedThreadId}] Рівень рекурсії: {currentDepth}");

            if (currentDepth < maxDepth)
            {
                Thread t1 = new Thread(() =>
                {
                    Recursive(currentDepth + 1, maxDepth);
                });

                Thread t2 = new Thread(() =>
                {
                    Recursive(currentDepth + 1, maxDepth);
                });
               
                t1.Start();
                t2.Start();

                t1.Join(); // чекає на завершення дочірніх потоків
                t2.Join();
            }
        }
    }
}
