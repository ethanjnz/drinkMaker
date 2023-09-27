
public class Water : Drink
{
    bool NeedsFlavor;

    public Water(string name, string color, double temperature, bool iscarbonated, int calories, bool needsflavor) : base(name, color, temperature, iscarbonated, calories)
    {
        NeedsFlavor = needsflavor;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Needs Flavor: {NeedsFlavor}");
    }
}