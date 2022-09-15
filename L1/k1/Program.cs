using System;

namespace k1
{
    class Program
    {
        static void Main()
        {
            PersonPrinter printer = new PersonPrinter();

            Person p = new Person(
                "Fornavn",
                "Larsen",
                25,
                new Person(
                    "Far",
                    "Larsen",
                    55,
                    new Person(
                        "Farfar",
                        "Larsen",
                        88,
                        null,
                        null
                    ),
                    new Person(
                        "Farmor",
                        "Larsen",
                        83,
                        null,
                        null)),
                new Person(
                    "Mor",
                    "Larsen",
                    54,
                    null,
                    null));

            Console.WriteLine("Selected person:");

            printer.PrintPerson(p);
            Console.WriteLine("Their family tree:");
            printer.PrintFamilyTree(p);
        }
    }
}
