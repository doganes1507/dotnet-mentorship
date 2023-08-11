namespace ClassWork;
using static Tasks.Tasks5;

public static class Program
{
    public static void Main()
    {
        // IsPalindromes
        Console.WriteLine("IsPalindromes");
        Console.WriteLine(IsPalindromes("Казак"));
        Console.WriteLine(IsPalindromes("ПотОп"));
        Console.WriteLine(IsPalindromes("БреВнО"));

        // IsPrime
        Console.WriteLine();
        Console.WriteLine("IsPrime");
        Console.WriteLine(IsPrime(13));
        Console.WriteLine(IsPrime(16));
        Console.WriteLine(IsPrime(9));

        // NumberOfVowels
        Console.WriteLine();
        Console.WriteLine("NumberOfVowels");
        Console.WriteLine(NumberOfVowels("hEllo"));
        Console.WriteLine(NumberOfVowels("GOOd"));
        Console.WriteLine(NumberOfVowels("bYe"));
        
        // NumberOfWords
        Console.WriteLine();
        Console.WriteLine("NumberOfWords");
        Console.WriteLine(NumberOfWords("Hello my dear friend!"));
        Console.WriteLine(NumberOfWords("How are you?"));
        Console.WriteLine(NumberOfWords("I love my country!"));
    }
}