namespace k1;

public class Person
{
    static int IdCounter = 0;
    int ID = ++IdCounter;
    public Person(string firstName, string lastName, int age, Person dad, Person mom)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Dad = dad;
        Mom = mom;
    }

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