using System.Numerics;

namespace Tasks;

public static class Tasks4
{
    // TODO: Все TODO перед коммитом необходимо удалить
    // Комментарии желательно тоже, если только ты не пишешь комментарии по самому коду
    public static void PrintList<T>(List<T> list)
    {
        // TODO: Каждый раз использовать циклы для вывода спсика - неудобно! Реализуй функцию, которая будет выводить
        // TODO: в консоль принимаемый список. Примеры:
        // { 1, 2, 3 }
        // { Moscow, Paris, Washington } если значения стрковые
        
        // Тип данных T, указанный в типе списка - магический знак, обобщающий все типы (то есть дает возможность
        // принимать любой тип (если только специально не ограничить T, например, только числовыми типами))
        
        // В новых версиях C# добавили возможность брать часть строки следующим образом:
        // Console.WriteLine("Hello"[1..3]);
        
        // Также добавили возможность брать элементы индексом с конца
        // Console.WriteLine("Hello"[^1]);
        // Console.WriteLine("Hello"[^2]);
        
        throw new NotImplementedException();
    }

    public static double CalculateAverage<T>(List<T> list) where T: INumber<T>
    {
        // TODO: На вход подается список с числовыми значениями (как дробными, так и целыми)
        // TODO: Необходимо посчитать среднее арифметическое значений этого списка и вернуть его
        // TODO: Если список пустой, вернуть 0
        
        throw new NotImplementedException();
    }
    
    public static List<double> CalculateSumAndProduct<T>(List<T> list) where T : INumber<T>
    {
        // TODO: На вход подается список с числовыми значениями (как дробными, так и целыми)
        // TODO: Необходимо посчитать сумму и произведение всех чисел, а затем вернуть их в виде списка из двух чисел
        
        throw new NotImplementedException();
    }

    public static int CountNumbersInRange(List<int> list, int min, int max)
    {
        // TODO: На вход подается список целых чисел, а также два целых числа min и max
        // TODO: Необходимо посчитать количество чисел в списке, удовлетворяющих условию: min <= list[i] <= max
        
        throw new NotImplementedException();
    }
    
    public static List<T> MultiplyList<T>(List<T> list, int multiplier)
    {
        // TODO: Еще нам очень не хватает умножения списка на число. Гарантируется, что 'multiplier' не может быть отрицательным

        throw new NotImplementedException();
    }
    
    public static void StopWord(string stopWord)
    {
        // TODO: Пользователь вводит целые числа в консоль, каждое число на новой строке. Необходимо продолжать
        // TODO: считывать числа, пока ввод пользователя не совпадет со строкой stopWord, которая подается на вход метода,
        // TODO: после чего нужно из введенных значений вывести в консоль минимальное, максимальное,
        // TODO: а также количество введенных чисел

        throw new NotImplementedException();
    }

    public static List<int> OnlyEvens(List<int> list)
    {
        // TODO: На вход приходит список целых чисел - необходимо вернуть список, состоящий только из четных элементов изначального списка
        
        throw new NotImplementedException();
    }

    public static List<string> FilterByKeyword(List<string> list, string keyWord)
    {
        // TODO: На вход приходит список строк, а также "ключевая строка". Необходимо вернуть список, в котором будут
        // TODO: содержаться только те строки, которые содержат в себе ключевую строку.
        // вместо оператора in из Python, в C# для строк (как и для списков) есть метод .Contains()

        throw new NotImplementedException();
    }

    public static void FilterTrash<T>(List<T> list)
    {
        // TODO: На вход подаается список значений самых разных типов. Необходимо вернуть список, состояющий
        // TODO: только из элементов типа int и double. Для сравнения типов переменных в C# есть оператор is
        // if (element is int)
        
        throw new NotImplementedException();
    }

    public static List<int> SpecialUniteLists(List<int> list1, List<int> list2)
    {
        // TODO: На вход подаются два списка целых чисел. Необходимо вернуть такой список, в котором содержатся
        // TODO: все элементы первого списка, а также те элементы второго списка, которые не встречаются в первом
        // Для списков {1, 2, 3, 3} и {1, 1, 4} результатом будет {1, 2, 3, 3, 4}
        
        throw new NotImplementedException();
    }
}