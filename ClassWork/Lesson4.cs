namespace ClassWork;

public static class Lesson4
{
    public static void Run()
    {
        var list1 = new List<int>();
        var list2 = new List<int> { 1, 2, 3, 4 };
        
        list1.Add(5);
        list1.Add(6);
        
        list1.AddRange(list2);

        foreach (var value in list1) Console.WriteLine(value);
        Console.WriteLine();
        
        // list1.InsertRange(0, list2);
        // list1.Insert(2, 10);

        list1.Remove(1);
        list1.RemoveAt(0);
        // list1.RemoveRange();
        // list1.RemoveAll(x => x > 10);
        
        foreach (var value in list1) Console.WriteLine(value);
        Console.WriteLine();
        
        // list1.Clear();
        Console.WriteLine(list1.Contains(1));
        Console.WriteLine(list1.Contains(2));
        Console.WriteLine(list1.Exists(x => x <= 0));

        Console.WriteLine(list1.FindIndex(x => x == 3));

        list1.Sort();
        list1.Reverse();

        list1 = list1.Select(x => x * 2).ToList();
        var x = list1.Sum();


        /*if ()
        {
            
        }
        else if ()
        {
            
        }
        
        else if ()
        {
            
        }*/

        var y = Convert.ToInt32(Console.ReadLine());
        switch (y)
        {
            case 1:
                Console.WriteLine(1);
                break;
            case 2:
                Console.WriteLine(2);
                break;
            default:
                Console.WriteLine("Не подошло");
                break;
        }
    }
}