namespace ClassWork;

public static class Lesson5
{
    public static void PrintHello()
    {
        Console.WriteLine("Hello everyone!");
    }

    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }
    
    public static void PrintPersonInfo(string firstName = "Ivan", string lastname = "Ivanov", int age = 18)
    {
        Console.WriteLine(firstName);
        Console.WriteLine(lastname);
        Console.WriteLine(age);
    }
    
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    
    public static double Sum(double a, double b)
    {
        return a + b;
    }
    
    public static double SumAnything<T>(T a, T b)
    {
        return Convert.ToDouble(a) + Convert.ToDouble(b);
    }
    
    public static double SumMany(params double[] numbers)
    {
        double result = 0;

        foreach (var number in numbers)
        {
            result += number;
        }

        return result;
    }
}