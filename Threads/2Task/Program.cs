namespace _2Task
{
    internal class Program
    {
        static readonly int width = Console.WindowWidth;
        static readonly int height = Console.WindowHeight;
        static readonly object consoleLock = new object();
        static Random random = new Random();

        class RainDrop
        {
            public int column;
            public int size;
            public int headPosition;
            public char[] chars;

            public RainDrop(int column)
            {
                this.column = column;
                Reset(initial: true);
            }

            public void Reset(bool initial = false)
            {
                size = random.Next(4, height / 2);
                headPosition = initial ? random.Next(-height, 0) : 0;
                chars = new char[size];
                for (int i = 0; i < size; i++)
                {
                    chars[i] = GetRandomLetter();
                }
            }

            public void Run()
            {
                while (true)
                {
                    Step();
                    Draw();
                    Thread.Sleep(random.Next(80, 150)); // різна швидкість
                }
            }

            private char GetRandomLetter()
            {
                return (char)random.Next(65, 91); // латинські великі літери (A-Z)
            }

            public void Step()
            {
                headPosition++;
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = GetRandomLetter();
                }

                if (headPosition - size > height)
                {
                    Reset();
                }
            }

            public void Draw()
            {
                lock (consoleLock) //Критична секція — синхронізований доступ
                {
                    for (int i = 0; i < size; i++)
                    {
                        int y = headPosition - i;
                        if (y >= 0 && y < height)
                        {
                            Console.SetCursorPosition(column, y);

                            if (i == 0)
                                Console.ForegroundColor = ConsoleColor.White;
                            else if (i == 1)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            else
                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                            Console.Write(chars[i]);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();

            for (int i = 0; i < width; i += 2)
            {
                // Два потоки на колонку (два RainDrop)
                RainDrop drop1 = new RainDrop(i);
                RainDrop drop2 = new RainDrop(i);

                Thread t1 = new Thread(drop1.Run);
                Thread t2 = new Thread(drop2.Run);

                t1.Start();
                t2.Start();

                threads.Add(t1);
                threads.Add(t2);
            }

            foreach (var t in threads)
            {
                t.Join();
            }
        }
    }
}
