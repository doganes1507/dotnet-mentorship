namespace ClassWork.Additional;

public class SqlRepository : IRepository
{
    public void SaveData()
    {
        Console.WriteLine("Реализация хранения данных в базе данных");
    }
}