using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class CarCollection
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(string name, int year) 
        {
            cars.Add(new Car(name, year));
        }
        public Car this[int index]
        {
            get
            {
                if (index >= 0 && index < cars.Count)
                    return cars[index];
                else
                    Console.WriteLine("Невірний індекс."); return new Car("",0);
            }
        }
        public int Count
        {
            get { return cars.Count; }
        }

        public void Clear()
        {
            cars.Clear();
        }
    }
}
