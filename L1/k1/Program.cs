static void Main()
{
    Person p = new Person()
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
}

class Person
{
    public Person Dad { get; set; }
    public Person Mom { get; set; }
    private string _FirstName;

    public string FirstName
    {
        get { return _FirstName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception($"{nameof(FirstName)} cannot be empty or null");
            _FirstName = value;
        }
    }

    private string _LastName;

    public string LastName
    {
        get { return _LastName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception($"{nameof(LastName)} cannot be empty or null");
            _LastName = value;
        }
    }

    private int _Age;

    public int Age
    {
        get { return _Age; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Age must be over 0");
            _Age = value;
        }
    }
}

class PersonPrinter
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