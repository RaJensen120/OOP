using System;
using k1;

//Person p = new Person("Fornavn", "Larsen", 25, null, null);
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

static void Main()
{
    Person p = new Person("Fornavn", "Larsen", 25, null, null);
    PersonPrinter printer = new PersonPrinter();
    printer.PrintPerson(p);
    printer.PrintFamilyTree(p);
    /*
    Person p = new Person(
        "Fornavn", 
        "Larsen",
        25,
        new Person(
            "Far",
            "Larsen,"
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
            */


    /*Person p = new Person()
    {
        FirstName = "Fornavn",
        LastName = "Larsen",
        Age = 25,
        Dad = new Person()
        {
            FirstName = "Far",
            LastName = "Larsen",
            Age = 55,
            Dad = new Person()
            {
                FirstName = "Farfar",
                LastName = "Larsen",
                Age = 88
            },
            Mom = new Person()
            {
                FirstName = "Farmor",
                LastName = "Larsen",
                Age = 83
            }
        },
        Mom = new Person()
        {
            FirstName = "Mor",
            LastName = "Larsen",
            Age = 54
            // ...
        }
    };
    */
}