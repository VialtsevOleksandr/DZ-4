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
        return base.GetInformation() + $"Швидкість течії: {CurrentSpeed} см/с\nЗагальна довжина: {TotalLength} м\n";
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
        // Create a River object
        var river = new River
        {
            XCoordinate = 45.678,
            YCoordinate = -67.890,
            Name = "Example River",
            Description = "A beautiful river",
            CurrentSpeed = 30.5,
            TotalLength = 1500.0
        };

        // Create a Mountain object
        var mountain = new Mountain
        {
            XCoordinate = 12.345,
            YCoordinate = 34.567,
            Name = "Example Mountain",
            Description = "A majestic mountain",
            HighestPoint = 4500.0
        };

        // Print information about the river and mountain
        Console.WriteLine("River Information:\n" + river.GetInformation());
        Console.WriteLine("Mountain Information:\n" + mountain.GetInformation());      
    }
}