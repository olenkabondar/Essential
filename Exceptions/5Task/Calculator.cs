namespace _5Task
{
    internal class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Помилка: ділення на нуль неможливе.");

            return a / b;
        }
    }
}
