namespace ClassWork.Additional;

public class FileRepository : IRepository
{
    public void SaveData()
    {
        Console.WriteLine("Реализация хранения данных в файле");
    }
}