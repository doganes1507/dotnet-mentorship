namespace ClassWork;

public static class Program
{
    public static void Main()
    {
        // PrintList
        Console.WriteLine("PrintList");
        Tasks.Lesson4.PrintList(new List<int>{1, 3, 4});
        Tasks.Lesson4.PrintList(new List<string>{"Hello world!", "Hi!", "Good bye!"});
        Tasks.Lesson4.PrintList(new List<double>{1.5, 3.2, 4.6});
        
        // CalculateAverage
        Console.WriteLine();
        Console.WriteLine("CalculateAverage");
        Tasks.Lesson4.CalculateAverage(new List<double> { 1, 1.3, 3, 4 });
        Tasks.Lesson4.CalculateAverage(new List<double>());
        Tasks.Lesson4.CalculateAverage(new List<double> { 98, 2.3, 8, 16 });
        
        // CalculateSumAndProduct
        Console.WriteLine();
        Console.WriteLine("CalculateSumAndProduct");
        Tasks.Lesson4.CalculateSumAndProduct(new List<double> { 1, 1.3, 3, 4 });
        Tasks.Lesson4.CalculateSumAndProduct(new List<double>());
        Tasks.Lesson4.CalculateSumAndProduct(new List<double> { 98, 2.3, 8, 16 });
        
        // CountNumbersInRange
        Console.WriteLine();
        Console.WriteLine("CountNumbersInRange");
        Tasks.Lesson4.CountNumbersInRange(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 6);
        Tasks.Lesson4.CountNumbersInRange(new List<int> { 19, 32, 67, 14, 51, 83, 97, 12, 100, 49 }, 35, 87);
        Tasks.Lesson4.CountNumbersInRange(new List<int> { 1, 3, 13, 4, 43, 21, 9, 18, 19, 10 }, 3, 20);

        // MultiplyList
        Console.WriteLine();
        Console.WriteLine("MultiplyList");
        Tasks.Lesson4.MultiplyList(new List<int> { 1, 2, 3 }, 2);
        Tasks.Lesson4.MultiplyList(new List<string> { "Hello", "Hi", "Good bye" }, 4);
        Tasks.Lesson4.MultiplyList(new List<double> { 5.1, 21.2, 16.6 }, 6); 

        // StopWord
        Console.WriteLine();
        Console.WriteLine("StopWord");
        Tasks.Lesson4.StopWord(13);
    
        // OnlyEvens
        Console.WriteLine();
        Console.WriteLine("OnlyEvens");
        Tasks.Lesson4.OnlyEvens(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Tasks.Lesson4.OnlyEvens(new List<int> { 19, 32, 67, 14, 51, 83, 97, 12, 100, 49 });
        Tasks.Lesson4.OnlyEvens(new List<int> { 1, 3, 13, 4, 43, 21, 9, 18, 19, 10 });
        
        // FilterByKeyword
        Console.WriteLine();
        Console.WriteLine("FilterByKeyword");
        Tasks.Lesson4.FilterByKeyword(new List<string> { "hello", "world", "friend" }, "hello world, my friend!");
        Tasks.Lesson4.FilterByKeyword(new List<string> { "hello", "hi", "good bye" }, "hello and good bye");
        Tasks.Lesson4.FilterByKeyword(new List<string> { "like", "cucumber", "friend", "!" }, "i like cucumber!");

        // SpecialUniteLists
        Console.WriteLine();
        Console.WriteLine("SpecialUniteLists");
        Tasks.Lesson4.SpecialUniteLists(new List<int> { 1, 2, 3, 3 }, new List<int> { 1, 4 });
        Tasks.Lesson4.SpecialUniteLists(new List<int> { 1, 2, 3, 3 }, new List<int> { 6, 9 });
        Tasks.Lesson4.SpecialUniteLists(new List<int> { 1, 2, 4, 5 }, new List<int> { 3, 5 });
    }
}