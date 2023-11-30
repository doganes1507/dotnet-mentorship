namespace ClassWork.Lesson9;

public class SqlRepository : IRepository
{
    public void SaveData()
    {
        Console.WriteLine("Реализация хранения данных в базе данных");
    }
}