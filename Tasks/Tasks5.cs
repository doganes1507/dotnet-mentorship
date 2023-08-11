namespace Tasks;

public static class Tasks5
{
    public static bool IsPalindrome(string word)
    {
        var lowerWord = word.ToLower();
        var reverseWord = new string(lowerWord.ToCharArray().Reverse().ToArray());

        return lowerWord == reverseWord;
    }

    public static bool IsPrime(int num)
    {
        var result = true;
        
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                result = false;
                break;
            }
        }

        return result;
    }
    
    public static int NumberOfVowels(string str)
    {
        var lowerStr = str.ToLower();
        var listOfVowels = new List<char> {'a', 'e', 'i', 'o', 'u'};
        var count = 0;
        
        foreach (var element in lowerStr)
        {
            if (listOfVowels.Contains(element))
            {
                count++;
            }
        }

        return count;
    }
    
    public static int NumberOfWords(string str)
    {
        return str.Count(space => space == ' ') + 1;
    }
}