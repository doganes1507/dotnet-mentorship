namespace ClassWork.Lesson9;

public class Person : ICloneable, IComparable
{
    public string FirstName;
    public string LastName;
    public int Age;

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public object Clone()
    {
        return new Person(FirstName, LastName, Age);
    }

    public int CompareTo(object? obj)
    {
        if (obj is not Person)
        {
            throw new ArgumentException("Person can only be compared to another Person");
        }
        
        var otherPerson = (Person)obj;

        if (Age > otherPerson.Age)
        {
            return 1;
        }

        if (Age < otherPerson.Age)
        {
            return -1;
        }

        return 0;
    }
}