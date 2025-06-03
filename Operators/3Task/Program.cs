namespace _3Task
{
    /*Створіть клас House з двома полями та властивостями. Створіть два методи Clone() та DeepClone(), 
     * які виконують поверхневе та глибоке копіювання відповідно. Реалізуйте найпростіший спосіб перевірки.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House
            {
                Room1 = "First room",
                Room2 = "Second room"
            };

            House clone = house.Clone();
            House deepClone = house.DeepClone();

            clone.Room1 = "Clone first room";
            clone.Room2 = "Clone second room";

            deepClone.Room1 = "Deep clone first room";
            deepClone.Room2 = "Deep clone second room";

            Console.WriteLine($"Original house: {house.Room1} + {house.Room2}");
            Console.WriteLine($"Clone copy first room: {clone.Room1} + {clone.Room2}");
            Console.WriteLine($"Deep copy first room: {deepClone.Room1} + {deepClone.Room2}");
        }
    }
    class House
    {
        public string room1;
        public string room2;
        public string Room1
        {
            get => room1;
            set => room1 = value;
        }
        public string Room2
        {
            get => room2;
            set => room2 = value;
        }

        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }
        public House DeepClone()
        {
            return new House
            {
                Room1 = this.Room1,
                Room2 = this.Room2
            };
        }
    }
}
