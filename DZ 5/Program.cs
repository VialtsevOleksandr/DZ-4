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
