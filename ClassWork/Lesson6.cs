using Tasks;

namespace ClassWork;

public static class Lesson6
{
    public static void RunDictionary()
    {
        // var lettersDictionary = new Dictionary<char, int>();

        /*var lettersDictionary = new Dictionary<char, int>
        {
            { 'a', 0 },
            { 'b', 0 },
            { 'c', 0 }
        };*/

        var letterDictionary = new Dictionary<char, int>
        {
            ['a'] = 0,
            ['b'] = 0,
            ['c'] = 0
        };

        letterDictionary['b'] = 3;
        Console.WriteLine(letterDictionary['b']);

        letterDictionary.Add('d', 0);
        letterDictionary['e'] = 0;

        foreach (var pair in letterDictionary)
        {
            Console.WriteLine(pair.Key + " " + pair.Value);
        }

        var myPair = new KeyValuePair<char, int>('f', 0);
        letterDictionary.Add(myPair.Key, myPair.Value);

        // lettersDictionary.ContainsKey('b');
        // lettersDictionary.ContainsValue(0);
        // letterDictionary.Remove('a');
    }

    public static void RunHashSet()
    {
        var mySet = new HashSet<int> { 1, 2, 3 };
        mySet.Add(4);
        mySet.Add(1);

        foreach (var element in mySet)
        {
            Console.WriteLine(element);
        }

        /*mySet.Remove(2);
        Console.WriteLine(mySet.Contains(3));*/

        // Console.WriteLine(mySet.Overlaps(new List<int> { 7, 5, 6 }));
        // Console.WriteLine(mySet.IsSupersetOf(new List<int> { 2, 3 }));
    }

    public static void RunValueAndReferenceTypes()
    {
        var a = 10;
        var b = a;
        b += 10;
        Console.WriteLine($"a: {a}, b: {b}");
        
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = list1.GetRange(0, list1.Count);
        list2.Add(10);
        Tasks4.PrintList(list1);
        Tasks4.PrintList(list2);
        
        var x = Convert.ToInt32(Console.ReadLine());
        ModifyInt(x);
        Console.WriteLine(x);

        var list = new List<int> { 1, 2, 3 };
        ModifyList(list);
        Tasks4.PrintList(list);

        var str = Console.ReadLine();
        ModifyString(str);
        Console.WriteLine(str);
    }

    private static void ModifyInt(int n)
    {
        n *= 10;
    }

    private static void ModifyList(List<int> list)
    {
        list.Add(123);
    }

    private static void ModifyString(string str)
    {
        str += "abcd";
    }
}