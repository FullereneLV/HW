using static System.Console;
using StoreInventorySystem.AllMenu;

namespace StoreInventorySystem;

public class Store
{
    public List<Beverage> Beverages = new();
    public List<Fish> Fishes = new();
    public List<Meat> Meats = new();
    public List<Milk> Milks = new();
    public List<Vegetables> VegetablesList = new();
    List<People> users = new List<People>();
    public MenegerMenu menegerMenu;
    RemoveProductMenu removeProductMenu;
    AddProductMenu addProduct;
    ShowProduct showProduct;
    public LoginMenu loginMenu;
    public Store()
    {
        menegerMenu = new MenegerMenu(this);
        loginMenu = new LoginMenu(this);
        removeProductMenu = new RemoveProductMenu(this);
        addProduct = new AddProductMenu(this);
        showProduct = new ShowProduct(this);
    }

    public void Run()
    {
        loginMenu.Start();
    }

    public void AddProduct(ProductItems item)
    {
        Clear();
        WriteLine("What name product do you want to add:");
        var name = ReadLine();
        WriteLine($"What {name} price is:");
        double p;
        Double.TryParse(ReadLine(), out p);
        switch (item)
        {
            case ProductItems.Beverage:
                bool isExistName = Beverages.Any(x => x.Name == name);
                WriteLine($"How much bottles of {name} are there?");
                var Quantity = int.Parse(ReadLine());
                if (!isExistName)
                {
                    Beverages.Add(new Beverage(name, p, Quantity));
                }
                else
                {
                    var obj = Beverages.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + Quantity;
                    obj.Price = p;
                }
                ConsoleUtils.WaitForKeyPress();
                break;
            case ProductItems.Fish:
                bool isExistFish = Fishes.Any(x => x.Name == name);
                WriteLine($"How much kg {name} are there?");
                var kg = int.Parse(ReadLine());
                if (!isExistFish)
                {
                    Fishes.Add(new Fish(name, p, kg));
                }
                else
                {
                    var obj = Fishes.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + kg;
                    obj.Price = p;
                }
                ConsoleUtils.WaitForKeyPress();
                break;
            case ProductItems.Meat:
                bool isExistMeat = Meats.Any(x => x.Name == name);
                WriteLine($"How much kg {name} are there?");
                var kgMeat = int.Parse(ReadLine());
                if (!isExistMeat)
                {
                    Meats.Add(new Meat(name, p, kgMeat));

                }
                else
                {
                    var obj = Meats.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + kgMeat;
                    obj.Price = p;
                }
                ConsoleUtils.WaitForKeyPress();
                break;
            case ProductItems.Milk:
                bool IsExistMilk = Milks.Any(x => x.Name == name);
                WriteLine($"How many liters of {name} are there?");
                var liters = int.Parse(ReadLine());
                if (!IsExistMilk)
                {
                    Milks.Add(new Milk(name, p, liters));

                }
                else
                {
                    var obj = Milks.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + liters;
                    obj.Price = p;
                }
                ConsoleUtils.WaitForKeyPress();
                break;
            case ProductItems.Vegetables:
                bool isExistVegetables = VegetablesList.Any(x => x.Name == name);
                WriteLine($"How much kg {name} are there?");
                var kgVegetables = int.Parse(ReadLine());
                if (!isExistVegetables)
                {
                    VegetablesList.Add(new Vegetables(name, p, kgVegetables));

                }
                else
                {
                    var obj = VegetablesList.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + kgVegetables;
                    obj.Price = p;
                }
                ConsoleUtils.WaitForKeyPress();
                break;
        }
        addProduct.AddMenu();

    }

    public void Remove(ProductItems item)
    {
        Clear();
        WriteLine("What name product do you want to remove:");
        var name = ReadLine();
        var found = false;

        switch (item)
        {
            case ProductItems.Beverage:
                foreach (var beverage in Beverages)
                {
                    var b = beverage.Name == name;
                    if (b != null)
                    {
                        Beverages.Remove(beverage);
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
                foreach (var fish in Fishes)
                {
                    var f = fish.Name == name;
                    if (f != null)
                    {
                        Fishes.Remove(fish);
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
                foreach (var meat in Meats)
                {
                    var m = meat.Name == name;
                    if (m != null)
                    {
                        Meats.Remove(meat);
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
                foreach (var milk in Milks)
                {
                    var milkItem = milk.Name == name;
                    if (milkItem != null)
                    {
                        Milks.Remove(milk);
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
                foreach (var veg in VegetablesList)
                {
                    var v = veg.Name == name;
                    if (v != null)
                    {
                        VegetablesList.Remove(veg);
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
        removeProductMenu.RemoveMenu();
    }

    public void ShowProduct(ProductItems item)
    {
        Clear();
        WriteLine(String.Format(ConsoleUtils.FormatStringTable, "Name", "Price", "Quantity"));

        switch (item)
        {
            case ProductItems.Beverage:
                if (Beverages.Count == 0)
                {
                    WriteLine("The bevereges are empty.");
                }
                
                foreach (var beverage in Beverages)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, beverage.Name ,beverage.Price, $"{beverage.Quantity} bottles"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,"Beverages contains: ",$"{Beverages.Sum(a=> a.Quantity)}"));
                break;
            case ProductItems.Fish:
                if (Fishes.Count == 0)
                {
                    WriteLine("The fishes are empty.");
                }
                foreach (var fish in Fishes)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, 
                                            fish.Name, fish.Price, fish.Quantity + " kg"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,
                                        "Fish contains: ", $"{Fishes.Sum(a=> a.Quantity)} kg"));

                break;
            case ProductItems.Meat:
                if (Meats.Count == 0)
                {
                    WriteLine("The meat is empty.");
                }
                foreach (var meat in Meats)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, meat.Name, meat.Price, meat.Quantity + " kg"));
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,"Meat contains:", $"{Meats.Sum(a=> a.Quantity)} kg"));

                break;
            case ProductItems.Milk:
                if (Milks.Count == 0)
                {
                    WriteLine("The milk is empty.");
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,"Milk contains:", $"{Milks.Sum(a=> a.Quantity)} liters"));
                foreach (var milk in Milks)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, milk.Name, milk.Price, milk.Quantity + " litres"));
                }
                break;
            case ProductItems.Vegetables:
                if (VegetablesList.Count == 0)
                {
                    WriteLine("The vegetables are empty.");
                }
                WriteLine(String.Format(ConsoleUtils.FormatStringQuantity,"Vegetables contain:", $"{VegetablesList.Sum(a=> a.Quantity)} kg"));
                foreach (var veg in VegetablesList)
                {
                    WriteLine(String.Format(ConsoleUtils.FormatStringTable, veg.Name, veg.Price, veg.Quantity + " kg"));
                }
                break;
        }
        ConsoleUtils.WaitForKeyPress();
        showProduct.ShowProductMenu();
    }
}
