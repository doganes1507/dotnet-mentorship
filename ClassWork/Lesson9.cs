using ClassWork.Additional;

namespace ClassWork;

public class Lesson9
{
    public static void RepositoryExampleRun()
    {
        var fileRepository = new FileRepository();
        var sqlRepository = new SqlRepository();

        ExampleMethod(sqlRepository);
    }

    public static void InterfaceImplementationRun()
    {
        var person1 = new Person("David", "Oganesyan", 20);
        var person2 = (Person)person1.Clone();
        var person3 = (Person)person1.Clone();

        person2.Age = 15;
        person3.Age = 25;
        
        Console.WriteLine(person1.Age);
        Console.WriteLine(person2.Age);

        ExampleMethod2(person1);

        var personList = new List<Person> { person1, person3, person2 };
        personList.Sort();

        foreach (var person in personList)
        {
            Console.WriteLine(person.Age);
        }
    }

    public static void ExampleMethod(IRepository repository)
    {
        repository.SaveData();
    }

    public static void ExampleMethod2(ICloneable someObject)
    {
        var otherObject = someObject.Clone();
    }
}