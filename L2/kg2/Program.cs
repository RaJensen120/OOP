using System;

namespace kg2
{
    class Program
    {
        static void Main()
        {
            Employee e = new Employee("John", "NotManager", 1000);
            Manager m = new Manager("Tom", "Manager", 2000, 500);
            Console.WriteLine(m.Bonus);
        }
    }
}