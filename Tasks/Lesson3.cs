namespace Tasks;

public static class Lesson3
{
    public static bool IsEven(int n)
    {
        // TODO: Реализовать функцию, принимающую целое число 'n' и возвращающую true, если число четное, иначе false
        
        return n % 2 == 0;
    }
    
    public static void Calculator()
    {
        // TODO: Написать стандартный калькулятор для консоли: ввод двух переменных и символа операции между
        // TODO: этими числами, затем вывод результата в консоль. Реализовать проверку на деление на ноль
        // TODO: Дополнительно: Для результатов типа 42.0 сделать вывод в виде целого числа с помощью проверки и
        // TODO: функции Math.Round()
        
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
        // TODO: Реализовать функцию, которая считает количество чисел между числами 'from' и 'to', которые
        // TODO: делятся на 3 и на 7
        // "and" в Python == "&" в C#
        // "or" в Python == "||" в C#

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
        // TODO: Реализовать функцию, подсчитывающую количество делителей числа 'n', включая 1 и само число
        // 2 <= n <= int.MaxValue

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
        // TODO: Реализовать функцию, принимающую целое число 'n' и преобразующую его в двоичный формат. Результат возвращается в виде string

        var binary = Convert.ToString(n, 2);
        // Console.WriteLine(binary);
        return binary;
    }
}