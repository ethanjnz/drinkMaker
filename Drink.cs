

public class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;

    public Drink(string name, string color, double temperature, bool iscarbonated, int calories)
    {
        Name = name;
        Color = color;
        Temperature = temperature;
        IsCarbonated = iscarbonated;
        Calories = calories;
    }

    public virtual void ShowDrink()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Temperature: {Temperature}");
        Console.WriteLine($"Is Carbonated: {IsCarbonated}");
        Console.WriteLine($"Calories: {Calories}");
    }
}