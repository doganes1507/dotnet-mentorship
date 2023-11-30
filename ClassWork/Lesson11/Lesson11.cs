namespace ClassWork.Lesson11;

public class Lesson11
{
    public static void Run()
    {
        var customer1 = new Customer(1234, "David", "Oganesyan");
        // var customer2 = customer1;
        var customer2 = new Customer(1234, "David", "AFJHjsdgfs");

        Console.WriteLine(customer1.GetHashCode());
        Console.WriteLine(customer2.GetHashCode());
        Console.WriteLine(customer1 == customer2);
        Console.WriteLine(customer1.Equals(customer2));
    }
}