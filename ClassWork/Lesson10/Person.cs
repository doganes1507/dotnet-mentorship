namespace ClassWork.Lesson10;

public class Person
{
    public string Name { get; }
    
    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be negative");
            }

            _age = value;
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string Greet()
    {
        return $"Hello, I am Person, my name is {Name}, I'm {Age} years old";
    }
}