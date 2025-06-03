namespace _2Task
{
    /*Створіть клас Block із 4 полями сторін, перевизначте в ньому методи: Equals - здатний порівнювати блоки між собою, 
     * ToString - повертає інформацію про поля блоку.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1, 2, 3, 4);
            Block block2 = new Block(1, 2, 3, 4);
            Block block3 = new Block(5, 6, 7, 8);

            Console.WriteLine($"ToString: {block1}");
            Console.WriteLine($"Equals block1 == block2: {block1.Equals(block2)}");
            Console.WriteLine($"Equals block1 == block3: {block1.Equals(block3)}");
        }
    }
}
