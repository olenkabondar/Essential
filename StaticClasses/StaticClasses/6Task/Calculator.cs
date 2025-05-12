namespace _6Task
{
    static class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static double Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("На нуль ділити не можна!");
                return 0;
            }
            return (double) x / y;
        }
    }
}
