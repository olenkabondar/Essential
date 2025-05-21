namespace _7Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть узагальнений клас MyClass, 
     * що містить статичний фабричний метод – T FacrotyMethod(), який породжуватиме екземпляри типу, 
     * вказаного як параметр типу (покажчика місця заповнення типом – Т). Яким має бути тип, що підставляється під T?*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = MyClass<Person>.FactoryMethod();
            Console.WriteLine(person);

            //Тип T повинен бути публічний конструктор без параметрів.
        }
    }
    public class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T(); // Створення об'єкта типу T
        }
    }
    public class Person
    {
        public string Name { get; set; } = "Olena Bondar";

        public override string ToString()
        {
            return $"Person: {Name}";
        }
    }
}
