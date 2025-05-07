namespace _3Task
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play() { Console.WriteLine("Play music is start!"); }
        public void Pause() { Console.WriteLine("Play music is on the pause!"); }
        public void Stop() { Console.WriteLine("Play music is stoped!"); }
        public void Record() { Console.WriteLine("Record music is start!"); }
        void IRecodable.Pause() { Console.WriteLine("Record music is on the pause!"); }
        void IRecodable.Stop() { Console.WriteLine("Record music is stoped!"); }
    }
}
