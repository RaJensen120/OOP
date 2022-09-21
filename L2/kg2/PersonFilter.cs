namespace kg2;

abstract class PersonFilter
{
    public bool FilterPredicate(Person person) // this does nothing
    {
        //List<Person> Filter(List<Person> plist);
        return true;

    }

    public virtual List<Person> Filter(List<Person> people)
    { 
        List<Person> result = new List<Person>();
        foreach (Person person in people)
            {
            if (FilterPredicate(person))
                result.Add(person);
            }
        return result;
    }
    

    public List<Person> NameFilter(List<Person> personList, string name)
    {
        List<Person> nameList = new List<Person>();
        foreach (var item in personList)
        {
            if(item.Name == name) 
                nameList.Add(item);
        }

        return nameList;
    }
    
    
}