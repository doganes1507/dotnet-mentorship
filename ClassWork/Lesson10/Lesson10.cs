namespace ClassWork.Lesson10;

public static class Lesson10
{
    public static void MethodOverridingRun()
    {
        var person = new Person("David", 20);
        var programmer = new Programmer("David", 20, "C#");
        
        SomeMethod(person);
        SomeMethod(programmer);
    }

    public static void SomeMethod(Person person)
    {
        Console.WriteLine(person.Greet());
    }

    public static void OperatorOverridingRun()
    {
        var coupon1 = new Coupon(15);
        var coupon2 = new Coupon(20);

        var coupon3 = coupon1 + coupon2 + new Coupon(10);

        Console.WriteLine(coupon3.DiscountAmount);
    }
}