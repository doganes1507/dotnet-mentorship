namespace ClassWork;

public static class Lesson7
{
    public static void StreamWriterRun()
    {
        var streamWriter = new StreamWriter("C:/Temp/MyFile.txt");
        
        streamWriter.WriteLine("Hello File!");
        streamWriter.WriteLine("Some Information here...");
        streamWriter.Write("abcd");
        streamWriter.Write("skjdfsdj");
        
        streamWriter.Close();
    }
    
    public static void StreamReaderRun()
    {
        var streamReader = new StreamReader(@"C:\Temp\MyFile.txt");

        /*streamReader.Read();
        streamReader.Read();*/

        /*streamReader.Peek();
        streamReader.Peek();*/
        
        Console.WriteLine(streamReader.ReadLine());
        Console.WriteLine(streamReader.ReadLine());
        Console.WriteLine(streamReader.ReadLine());
        
        streamReader.Close();

    }

    public static void SpecialFolderRun()
    {
        // var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/MyFile.txt";
        
        var streamWriter = new StreamWriter(path);
        streamWriter.WriteLine("Hello my documents");
        
        streamWriter.Close();
    }

    public static void RandomRun()
    {
        var random = new Random();
        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next());
        Console.WriteLine(random.NextDouble());
        Console.WriteLine(random.NextDouble());
        Console.WriteLine(random.NextDouble());
    }
}