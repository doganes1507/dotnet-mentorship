namespace Tasks;

public static class Tasks6
{
    public static void PrintDictionary(Dictionary<int, string> dict)
    {
        var count = 1;
        var result = "{ ";

        foreach (var pair in dict)
        {
            result += $"{pair.Key} = {pair.Value}";

            if (count < dict.Count)
            {
                result += "; ";
            }

            count++;
        }

        result += " }";

        Console.WriteLine(result);
    }

    public static KeyValuePair<char, int> NumberOfSymbol(string str)
    {
        var lowStr = str.ToLower();
        var dict = new Dictionary<char, int>();

        foreach (var el in lowStr)
        {
            if (!dict.ContainsKey(el))
            {
                dict.Add(el, 1);
            }
            else
            {
                dict[el]++;
            }
        }

        foreach (var pair in dict)
        {
            if (pair.Value == dict.Values.Max())
            {
                return pair;
            }
        }

        throw new Exception();
    }
    
    public static int CountOfElements<T>(List<T> list)
    {
        var newList = new List<T>();

        foreach (var el in list)
        {
            if (!newList.Contains(el))
            {
                newList.Add(el);
            }
        }

        return newList.Count;
    }
}