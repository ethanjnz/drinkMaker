



public class Wine : Drink
{
    public string Region;
    public int Year;

    public Wine(string name, string color, double temperature, int calories, string region, int year)
    // remember that base is the params of the parent contructor
    : base(name, color, temperature, false, calories)
    {
        Region = region;
        Year = year;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Year: {Year}");
    }
}