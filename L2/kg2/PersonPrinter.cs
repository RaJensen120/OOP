namespace kg2
{
    public class PersonPrinter
    {
        public void PrintPerson(Person p)
        {
            Console.WriteLine($"{p.Name}, {p.Age}");
        }
    }
}