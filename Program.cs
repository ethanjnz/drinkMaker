// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

Coffee MyCoffee = new("Dunkin", "Black", 100.00, 60, "Medium", "Columbian");
Soda MySoda = new("Sprite", "Clear", 10.0, 200, false);
Water MyWater = new("Water", "Clear", 30.0, false, 0, true);
Wine MyWine = new("Nior", "Red", 48.0, 100, "France", 2016);

List<Drink> AllDrinks = new();

AllDrinks.Add(MyCoffee);
AllDrinks.Add(MySoda);
AllDrinks.Add(MyWater);
AllDrinks.Add(MyWine);

// this is a foreach loop (NOT a for loop)
foreach (Drink d in AllDrinks)
{
    d.ShowDrink();
}

// Coffee MyDrink = new Soda("Pepsi", "Black", 32.0, 300, true);
// we cant create this instance because we can't convert the coffee instance into a soda
// they take in two different params and fields 



