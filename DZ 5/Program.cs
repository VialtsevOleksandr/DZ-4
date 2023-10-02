// See https://aka.ms/new-console-template for more information
public abstract class GeographicObject
{
    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual string GetInformation()
    {
        return $"Назва: {Name}\nХ: {XCoordinate}\nY: {YCoordinate}\nОпис: {Description}\n";
    }
}
public class River : GeographicObject
{
    public double CurrentSpeed { get; set; }
    public double TotalLength { get; set; }

    public override string GetInformation()
    {
        return base.GetInformation() + $"Швидкiсть течiї: {CurrentSpeed} см/с\nЗагальна довжина: {TotalLength} м\n";
    }
}
public class Mountain : GeographicObject
{
    public double HighestPoint { get; set; }

    public override string GetInformation()
    {
        return base.GetInformation() + $"Найвища точка: {HighestPoint} м\n";
    }
}
class Program
{
    static void Main(string[] args)
    {
        var river = new River
        {
            XCoordinate = 46.18,
            YCoordinate = 30.16,
            Name = "Днiстер",
            Description = "Гарна та довга рiчка",
            CurrentSpeed = 2,
            TotalLength = 1362
        };

        var mountain = new Mountain
        {
            XCoordinate = 48.09,
            YCoordinate = 29.30,
            Name = "Говерла",
            Description = "Найвища гора в Українi",
            HighestPoint = 2061
        };

        Console.WriteLine("Iнформацiя про рiчки:\n" + river.GetInformation());
        Console.WriteLine("Iнформацiя про гори:\n" + mountain.GetInformation());      
    }
}
