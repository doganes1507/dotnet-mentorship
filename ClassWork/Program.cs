namespace ClassWork;

using static Tasks.Tasks6;

public static class Program
{
    public static void Main()
    {
        // PrintDictionary
        Console.WriteLine("PrintDictionary");
        PrintDictionary(new Dictionary<int, string>
            {
                { 1, "hello" },
                { 2, "world" },
                { 3, "!" }
            }
        );
        PrintDictionary(new Dictionary<int, string>
            {
                { 54, "apple" },
                { 21, "!@#$%^&*()_+" },
            }
        );
        PrintDictionary(new Dictionary<int, string>
            {
                { 4, "C#" },
                { 16, "1234567890" },
                { 887, "I love my dog" },
                { 654, "Ctrl C + Ctrl V" }
            }
        );
        
        // NumberOfSymbol
        Console.WriteLine();
        Console.WriteLine("NumberOfSymbol");
        Console.WriteLine(NumberOfSymbol("abca"));
        Console.WriteLine(NumberOfSymbol("Hello world"));
        Console.WriteLine(NumberOfSymbol("OOooAAoAa"));

        // CountOfElements
        Console.WriteLine();
        Console.WriteLine("CountOfElements");
    }
    
}