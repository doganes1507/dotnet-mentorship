using System.Numerics;

namespace Tasks;

public static class Lesson4
{
    public static void PrintList<T>(List<T> list)
    {
        var result = "{ ";

        for (int i = 0; i < list.Count; i++)
        {
            result += list[i];
            if (i < list.Count - 1)
            {
                result += ",";
                result += " ";
            }
        }

        result += " }";

        Console.WriteLine(result);
    }

    public static double CalculateAverage<T>(List<T> list) where T : INumber<T>
    {
        if (list.Count == 0)
        {
            return 0;
        }

        else
        {
            double sum = 0;

            foreach (var t in list)
            {
                sum += Convert.ToDouble(t);
            }

            return sum / list.Count;
        }
    }

    public static List<double> CalculateSumAndProduct<T>(List<T> list) where T : INumber<T>
    {
        var result = new List<double>();

        if (list.Count != 0)
        {
            double sum = 0;
            double product = 1;

            foreach (var t in list)
            {
                sum += Convert.ToDouble(t);
                product *= Convert.ToDouble(t);
            }
            
            result.Add(sum);
            result.Add(product);
        }
        
        return result;
    }

    public static int CountNumbersInRange(List<int> list, int min, int max)
    {
        var count = 0;

        foreach (var i in list)
        {
            if (min <= i && i <= max)
            {
                count++;
            }
        }

        return count;
    }

    public static List<T> MultiplyList<T>(List<T> list, int multiplier)
    {
        var newList = new List<T>();
        for (int i = 0; i < multiplier; i++)
        {
            newList.AddRange(list);
        }

        return newList;
    }

    public static int StopWord(int stopWord)
    {
        var count = 1;
        var list = new List<int>();

        while (true)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (stopWord == input)
            {
                list.Add(input);
                break;
            }

            else
            {
                list.Add(input);
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine(list.Min());
        Console.WriteLine(list.Max());
        Console.WriteLine(count);
        
        return count;
    }

    public static List<int> OnlyEvens(List<int> list)
    {
        var newList = new List<int>();
        
        foreach (var element in list)
        {
            if (element % 2 == 0)
            {
                newList.Add(element);
            }  
        }

        return newList;
    }

    public static List<string> FilterByKeyword(List<string> list, string keyWord)
    {
        var newList = new List<string>();

        foreach (var element in list)
        {
            if (element.Contains(keyWord))
            {
                newList.Add(element);
            }
        }

        return newList;
    }

    public static List<double> FilterTrash<T>(List<T> list)
    {
        var newList = new List<double>();
        foreach (var element in list)
        {
            if (element is double || element is int)
            {
                newList.Add(Convert.ToDouble(element));
            }
        }

        return newList;
    }

    public static List<int> SpecialUniteLists(List<int> list1, List<int> list2)
    {
        var newList = list1;

        foreach (var element in list2)
        {
            if (!list1.Contains(element))
            {
                newList.Add(element);
            }
        }

        return newList;
    }
}