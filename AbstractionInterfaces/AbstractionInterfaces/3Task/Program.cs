namespace _3Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по 3 методи
    void Play() / void Pause() / void Stop() та void Record() / void Pause() / void Stop() відповідно. 
    Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable. 
    Написати програму, яка виконує програвання та запис.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IPlayable play = player;
            IRecodable record = player;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Play music!");
            Console.ResetColor();
            play.Play();
            play.Pause();
            play.Stop();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Record music!");
            Console.ResetColor();
            record.Record();
            record.Pause();
            record.Stop();
        }
    }
}
