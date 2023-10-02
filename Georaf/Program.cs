// See https://aka.ms/new-console-template for more information
public interface IGeographicObject
{
    double XCoordinate { get; set; }
    double YCoordinate { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    string GetInformation();
}

public class River : IGeographicObject
{
    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double CurrentSpeed { get; set; }
    public double TotalLength { get; set; }

    public string GetInformation()
    {
        return $"Назва: {Name}\nХ: {XCoordinate}\nY: {YCoordinate}\nОпис: {Description}\n" +
               $"Швидкість течiї: {CurrentSpeed} см/с\nЗагальна довжина: {TotalLength} м\n";
    }
}
public class Mountain : IGeographicObject
{
    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public string GetInformation()
    {
        return $"Назва: {Name}\nХ: {XCoordinate}\nY: {YCoordinate}\nОпис: {Description}\n" +
               $"Найвища точка: {HighestPoint} м\n";
    }
}


