using System;

namespace kg2
{
    class Program
    {
        static void Main()
        {
            
            Employee e = new Employee("John", 20, "NotManager", 1000, 2);
            Manager m = new Manager("Tom", 21, "Manager", 2000, 10, 500);
            Console.WriteLine(e.calculateYearlySalary(e));
            Console.WriteLine(m.calculateYearlySalary(m));
            
            
            //With a Person-list:
            List<Person> plist = new List<Person>();
            plist.Add(new Person("Thomas", 25));
            plist.Add(new Person("Erik",30));
            plist.Add(new Employee("Bo",24, "NotManager", 1200, 5));
            plist.Add(new Employee("Hans", 27, "NotManager", 2100, 8));
            plist.Add(new Person("Kurt",40));
            plist.Add(e);
            plist.Add(m);
            //I can retrieve a list of all named ''Thomas'' using:
            //PersonFilter pfilter = new NameFilter("Thomas"); THIS SHOULD BE UNCOMMENTED IN THE FINAL VERSION
            //List<Person> filteredList = pfilter.Filter(plist);
            
        }
    }
}