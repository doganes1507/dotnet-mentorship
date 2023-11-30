namespace ClassWork.Lesson10;

public class Programmer : Person
{
    public string ProgrammingLanguage { get; set; }

    public Programmer(string name, int age, string programmingLanguage) : base(name, age)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override string Greet()
    {
        return
            $"Hello, I am a Programmer, my name is {Name}, I'm {Age} years old. My primary programming language is {ProgrammingLanguage}";
    }
}