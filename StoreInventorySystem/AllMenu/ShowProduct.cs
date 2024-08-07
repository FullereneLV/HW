using static System.Console;

namespace StoreInventorySystem.AllMenu;

public class ShowProduct: PatternMenu
{
    public ShowProduct(Store menu) : base(menu)
    {
    }

    public void Run()
    {
        Clear();
        string prompt = "Show product:";
        string[] options = { "Beverage", "Fish", "Meat", "Milk", "Vegetables", "Back to Meneger menu" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
                Show(ProductItems.Beverage);
                break;
            case 1:
                Show(ProductItems.Fish);
                break;
            case 2:
                Show(ProductItems.Meat);
                break;
            case 3:
                Show(ProductItems.Milk);
                break;
            case 4:
                Show(ProductItems.Vegetables);
                break;
            case 5:
                MyStore.MyMenegerMenu.Run();
                break;
        }
    }

     private void Show(ProductItems item)
    {
        Clear();
        WriteLine(String.Format(ConsoleUtils.FormatStringTable, "Name", "Price", "Quantity"));

        switch (item)
        {
            case ProductItems.Beverage:
                if (MyStore.Beverages.Count == 0)
                {
                    WriteLine("The bevereges are empty.");
                }
                
                foreach (var beverage in MyStore.Beverages)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, beverage.Name ,beverage.Price, beverage.CountAmount() + " bottles"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,"Beverages contains: ", MyStore.Beverages.Sum(a=> a.CountAmount()) + " bottles"));
                break;
            case ProductItems.Fish:
                if (MyStore.Fishes.Count == 0)
                {
                    WriteLine("The fishes are empty.");
                }
                foreach (var fish in MyStore.Fishes)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, 
                                            fish.Name, fish.Price, fish.CountAmount() + " kg"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,
                                        "Fish contains: ", MyStore.Fishes.Sum(a=> a.CountAmount()) + " kg"));

                break;
            case ProductItems.Meat:
                if (MyStore.Meats.Count == 0)
                {
                    WriteLine("The meat is empty.");
                }
                foreach (var meat in MyStore.Meats)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, meat.Name, meat.Price, meat.CountAmount() + " kg"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,"Meat contains:", MyStore.Meats.Sum(a=> a.CountAmount()) + " kg"));
                break;
            case ProductItems.Milk:
                if (MyStore.Milks.Count == 0)
                {
                    WriteLine("The milk is empty.");
                }
                foreach (var milk in MyStore.Milks)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, milk.Name, milk.Price, milk.CountAmount() + " liters"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,"Milk contains:", MyStore.Milks.Sum(a=> a.CountAmount()) + "liters"));
                break;
            case ProductItems.Vegetables:
                if (MyStore.VegetablesList.Count == 0)
                {
                    WriteLine("The vegetables are empty.");
                }
                foreach (var veg in MyStore.VegetablesList)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, veg.Name, veg.Price, veg.CountAmount() + " kg"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity, "Vegetables contain:", MyStore.VegetablesList.Sum(a => a.CountAmount()) + " kg"));
                break;
        }
        ConsoleUtils.WaitForKeyPress();
        Run();
    }
}
