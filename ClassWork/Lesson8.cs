namespace ClassWork;

public class MyClass
{
    public int X;
    public readonly int Y;
    public const int Z = 100;

    public MyClass(int x = -1, int y = -1)
    {
        X = x;
        Y = y;

        Console.WriteLine("Объект класса был создан");
    }

    public void SomeMethod()
    {
        
    }

    public static void SomeStaticMethod()
    {
        
    }
}

public class Car
{
    public readonly string Make;
    public readonly string Model;
    public readonly int Year;
    public readonly int MaxSpeed;
    public readonly string GasType;

    private bool _isEngineRunning;
    private int _currentEngineRpm;

    public Car(string make, string model, int year, int maxSpeed, string gasType)
    {
        Make = make;
        Model = model;
        Year = year;
        MaxSpeed = maxSpeed;
        GasType = gasType;
        
        _isEngineRunning = false;
        _currentEngineRpm = 0;
    }

    public void StartEngine()
    {
        _isEngineRunning = true;
        _currentEngineRpm = 800;
    }

    public void StopEngine()
    {
        _isEngineRunning = false;
        _currentEngineRpm = 0;
    }

    public void Accelerate(int x)
    {
        if (x <= 0)
        {
            throw new ArgumentException();
        }
        if (!_isEngineRunning)
        {
            throw new Exception("Двигатель не запущен");
        }

        _currentEngineRpm += x;
    }

    public void Break(int x)
    {
        if (x <= 0)
        {
            throw new ArgumentException();
        }

        _currentEngineRpm -= x;
        if (_currentEngineRpm < 0)
        {
            _currentEngineRpm = 0;
            _isEngineRunning = false;
        }
    }
}

public static class Lesson8
{
    public static void Run()
    {
        var myNewCar = new Car("Toyota", "Camry", 2018, 280, "95");
        
        myNewCar.StartEngine();
        myNewCar.Accelerate(100);
        myNewCar.Break(100);
    }
}