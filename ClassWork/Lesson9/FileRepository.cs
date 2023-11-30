namespace ClassWork.Lesson9;

public class FileRepository : IRepository
{
    public void SaveData()
    {
        Console.WriteLine("Реализация хранения данных в файле");
    }
}