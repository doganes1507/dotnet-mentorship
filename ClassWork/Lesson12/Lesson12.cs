namespace ClassWork.Lesson12;

public class Lesson12
{
    public static void Run()
    {
        var person = new Person("asjd", 123, Gender.Male);
        Console.WriteLine(person.Gender);

        var gender = Gender.Unknown;
        person.Gender = gender;

        var input = Console.ReadLine();
        
        
        if (Enum.TryParse(input, true, out Gender newGender))
        {
            Console.WriteLine(newGender);
        }
        else
        {
            Console.WriteLine("Гендер не распознан");
        }
        
        Sort(new List<int> {1, 2, 3}, SortingAlgorithms.QuickSort);

    }

    public static void Sort(List<int> list, SortingAlgorithms sortingAlgorithm)
    {
        switch (sortingAlgorithm)
        {
            case SortingAlgorithms.BubbleSort:
                break;
            case SortingAlgorithms.InsertionSort:
                break;
            case SortingAlgorithms.QuickSort:
                break;
        }

        // if (sortingAlgorithm == SortingAlgorithms.BubbleSort)
        // {
        //     
        // }
        // else if (sortingAlgorithm == SortingAlgorithms.InsertionSort)
        // {
        //     
        // }
        // else if (sortingAlgorithm == SortingAlgorithms.QuickSort)
        // {
        //     
        // }
    }
}