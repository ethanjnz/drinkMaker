

public class Soda : Drink
{
    bool IsDiet;
    public Soda(string name, string color, double temperature, int calories, bool isdiet)
    // remember that base is the params of the parent contructor
    : base(name, color, temperature, true, calories)
    {
        IsDiet = isdiet;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Is Diet: {IsDiet}");
    }
}