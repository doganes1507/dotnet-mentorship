namespace Tasks;

public static class Tasks3
{
    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    public static void Calculator()
    {
        var num1 = Convert.ToDouble(Console.ReadLine());
        var op = Convert.ToChar(Console.ReadLine());
        var num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine(num1 + num2);
                break;
            case '-':
                Console.WriteLine(num1 - num2);
                break;
            case '*':
                Console.WriteLine(num1 * num2);
                break;
            case '/' when num2 != 0:
                Console.WriteLine(num1 / num2);
                break;
            case '/':
                Console.WriteLine("На ноль делить нельзя!");
                break;
            case '%' when num2 != 0:
                Console.WriteLine(num1 % num2);
                break;
            case '%':
                Console.WriteLine("На ноль делить нельзя!");
                break;
        }
    }

    public static int SpecialNumberCount(int from, int to)
    {
        var count = 0;

        for (var i = from; i <= to; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                count++;
            }
        }

        // Console.WriteLine(count);
        return count;
    }

    public static int DividerCount(int n)
    {
        var count = 0;

        for (var i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        // Console.WriteLine(count);
        return count;
    }

    public static string ToBinary(int n)
    {
        var binary = Convert.ToString(n, 2);
        // Console.WriteLine(binary);
        return binary;
    }
}