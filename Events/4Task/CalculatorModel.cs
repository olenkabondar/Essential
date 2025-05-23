using System.Windows;

namespace _4Task
{
    public class CalculatorModel
    {
        public double Add(int a, int b) => a + b;
        public double Subtract(int a, int b) => a - b;
        public double Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                MessageBox.Show("Ділити на нуль не можна!");
                return double.NaN;
            }
            else { return a / b; }
        }
    }
}
