namespace _1Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть програму, яка виводитиме на екран ланцюжки падаючих символів. Довжина кожного ланцюжка визначається випадково. 
     * Перший символ ланцюжка – білий, другий символ – світло-зелений, решта символів темно-зелені. 
     * Під час падіння ланцюжка на кожному кроці всі символи змінюють своє значення. 
     * Дійшовши до кінця, ланцюжок зникає і зверху формується новий ланцюжок. Дивіться example1.png представлений як зразок.*/
    class Program
    {
        static readonly int width = Console.WindowWidth;
        static readonly int height = Console.WindowHeight;

        static Random random = new Random();

        public class RainDrop
        {
            public int column;
            public int size;
            public int headPosition;
            public char[] chars;

            public RainDrop(int column)
            {
                this.column = column;
                Reset();
            }

            public void Reset()
            {
                size = random.Next(4, height / 2); //визначення випадкової довжини
                headPosition = 0;
                chars = new char[size];
                for (int i = 0; i < size; i++)
                {
                    chars[i] = GetRandomChar();
                }
            }

            public void Step()
            {
                headPosition++;
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = GetRandomChar();
                }

                if (headPosition - size > height)
                {
                    Reset();
                }
            }

            private char GetRandomChar()
            {
                return (char)random.Next(65, 91); // латинські великі літери (A-Z)
            }

            public void SetColor()
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
        static void Main(string[] args)
        {
            List<RainDrop> drops = new List<RainDrop>();
            for (int i = 0; i < width; i += 2) // Через одну колонку
            {
                drops.Add(new RainDrop(i));
            }

            while (true)
            {
                Console.Clear();

                foreach (var drop in drops)
                {
                    drop.Step();
                    drop.SetColor();
                }

                Thread.Sleep(200);
            }
        }
    }
}
