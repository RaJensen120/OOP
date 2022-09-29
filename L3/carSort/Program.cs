using System;
using carSort;

namespace carSort
{
    class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>(){
                new Car("Skoda", "Fabia", 50000m),
                new Car("Skoda", "Octavia", 60000m),
                new Car("Fiat", "500", 12345m),
                new Car("Ford", "Mustang", 9000000m),
                new Car("Ford", "Mustang", 9000001m)
            };
            IComparer<Car> cc = null;

            while (true)
            {
                string s = Console.ReadLine();
                if (s == "q")
                {
                    return;
                }
                if (s == "m")
                {
                    cc = new MakeComparer();
                }
                if (s == "p")
                {
                    cc = new PriceComparer();
                }
                cars.Sort(cc);
                Console.WriteLine("Sorted by " + cc.GetType().Name);
                foreach (Car car in cars)
                {
                    Console.WriteLine($" {car.Make} {car.Model} {car.Price}");
                }
            }

        }
    }
}
