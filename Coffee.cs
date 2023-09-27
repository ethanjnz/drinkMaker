


public class Coffee : Drink
{
    public string Roast;
    public string Beans;

    public Coffee(string name, string color, double temperature, int calories, string roast, string beans)
    // remember that base is the params of the parent contructor
    : base(name, color, temperature, false, calories)
    {
        Roast = roast;
        Beans = beans;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast: {Roast}");
        Console.WriteLine($"Beans: {Beans}");
    }
}