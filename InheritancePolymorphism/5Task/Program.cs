namespace _5Task
{
     /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити клас Printer. У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу. 
     * Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра, 
     * рядки, передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Its a basic printer - white color");

            printer = new RedPrinter();
            printer.Print("Its a red printer - red color");

            printer = new GreenPrinter();
            printer.Print("Its a green printer - green color");

            printer = new BluePrinter();
            printer.Print("Its a blue printer - blue color");

            printer = new YellowPrinter();
            printer.Print("Its a yellow printer - yellow color");

            printer = new MagentaPrinter();
            printer.Print("Its a magenta printer - violet color");
        }
    }
}
