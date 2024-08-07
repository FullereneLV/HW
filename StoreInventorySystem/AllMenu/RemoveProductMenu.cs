using static System.Console;

namespace StoreInventorySystem.AllMenu;

public class RemoveProductMenu
{
    private Store MySrote;

    public RemoveProductMenu(Store menu)
    {
        MySrote = menu;
    }
    public void Run()
    {
        Clear();
        string prompt = "Remove product:";
        string[] options = { "Beverage", "Fish", "Meat", "Milk", "Vegetables", "Back to Meneger menu" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
                Remove(ProductItems.Beverage);
                break;
            case 1:
                Remove(ProductItems.Fish);
                break;
            case 2:
                Remove(ProductItems.Meat);
                break;
            case 3:
                Remove(ProductItems.Milk);
                break;
            case 4:
                Remove(ProductItems.Vegetables);
                break;
            case 5:
                MySrote.MyMenegerMenu.Run();
                break;
        }
    }

    private void Remove(ProductItems item)
    {
        Clear();
        WriteLine($"What name {item.ToString()} do you want to remove:");
        var name = ReadLine();
        var found = false;

        switch (item)
        {
            case ProductItems.Beverage:
                foreach (var beverage in MySrote.Beverages)
                {
                    var b = beverage.Name == name;
                    if (b != null)
                    {
                        MySrote.Beverages.Remove(beverage);
                        WriteLine($"{name} removed successfully.");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    WriteLine($"{name} not found.");
                }
                break;
            case ProductItems.Fish:
                foreach (var fish in MySrote.Fishes)
                {
                    var f = fish.Name == name;
                    if (f != null)
                    {
                        MySrote.Fishes.Remove(fish);
                        WriteLine($"{name} removed successfully.");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    WriteLine($"{name} not found.");
                }
                break;
            case ProductItems.Meat:
                foreach (var meat in MySrote.Meats)
                {
                    var m = meat.Name == name;
                    if (m != null)
                    {
                        MySrote.Meats.Remove(meat);
                        WriteLine($"{name} removed successfully.");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    WriteLine($"{name} not found.");
                }
                break;
            case ProductItems.Milk:
                foreach (var milk in MySrote.Milks)
                {
                    var milkItem = milk.Name == name;
                    if (milkItem != null)
                    {
                        MySrote.Milks.Remove(milk);
                        WriteLine($"{name} removed successfully.");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    WriteLine($"{name} not found.");
                }
                break;
            case ProductItems.Vegetables:
                foreach (var veg in MySrote.VegetablesList)
                {
                    var v = veg.Name == name;
                    if (v != null)
                    {
                        MySrote.VegetablesList.Remove(veg);
                        WriteLine($"{name} removed successfully.");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    WriteLine($"{name} not found.");
                }
                break;
        }
        ConsoleUtils.WaitForKeyPress();
        Run();
    }
}
