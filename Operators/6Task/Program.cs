using System.Text;

namespace _6Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
     * Створіть структуру, яка описує точку у тривимірній системі координат.
     * Організуйте можливість складання двох точок через використання навантаження оператора +.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Point3D point1 = new Point3D(1.0, 2.5, 3.5);
            Point3D point2 = new Point3D(4.5, 2.0, 1.5);

            Point3D sum = point1 + point2;

            Console.WriteLine($"Координати точки 1: {point1}");
            Console.WriteLine($"Координати точки 2: {point2}");
            Console.WriteLine($"Сума точок: {sum}");
        }
    }
    struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Перевантаження оператора +
        public static Point3D operator +(Point3D a, Point3D b)
        {
            return new Point3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public override string ToString()
        {
            return $"[{X}, {Y}, {Z}]";
        }
    }
}
