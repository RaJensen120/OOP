using System;

namespace kg2
{
    class Program
    {
        static void Main()
        {
            Employee e = new Employee("John", "NotManager", 1000, 2);
            Manager m = new Manager("Tom", "Manager", 2000, 10, 500);
            Console.WriteLine(e.calculateYearlySalary(e));
            Console.WriteLine(m.calculateYearlySalary(m));
            
        }
    }
}