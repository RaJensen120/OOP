namespace k1
{
    public class PersonPrinter
    {
        public void PrintPerson(Person p)
        {
            Console.WriteLine($"{p.FirstName} {p.LastName}, {p.Age}");
        }

        public void PrintFamilyTree(Person p)
        {
            PrintPerson(p);
            if (p.Dad != null)
                PrintFamilyTree(p.Dad);
            if (p.Mom != null)
                PrintFamilyTree(p.Mom);
        }
    }
}