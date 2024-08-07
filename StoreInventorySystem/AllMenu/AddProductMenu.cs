using static System.Console;
using StoreInventorySystem.AllProducts;

namespace StoreInventorySystem.AllMenu;

public class AddProductMenu : PatternMenu
{
    public AddProductMenu(Store store): base(store){
    }

    public override void Run()
    {
        Clear();
        string prompt = "Add product:";
        string[] options = { "Beverage", "Fish", "Meat", "Milk", "Vegetables", "Back to Meneger menu" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
                AddProduct(ProductItems.Beverage);
                break;
            case 1:
                AddProduct(ProductItems.Fish);
                break;
            case 2:
               AddProduct(ProductItems.Meat);
                break;
            case 3:
                AddProduct(ProductItems.Milk);
                break;
            case 4:
                AddProduct(ProductItems.Vegetables);
                break;
            case 5:
                MyStore.MyMenegerMenu.Run();
                break;
        }
    }
    
    private void AddProduct(ProductItems item)
    {
        Clear();
        WriteLine($"What name {item.ToString()} do you want to add:");
        var name = ReadLine();
        WriteLine($"What {name} price is:");
        double p;
        Double.TryParse(ReadLine(), out p);
        switch (item)
        {
            case ProductItems.Beverage:
                bool isExistName = MyStore.Beverages.Any(x => x.Name == name);
                WriteLine($"How much bottles of {name} are there?");
                var Quantity = int.Parse(ReadLine());
                if (!isExistName)
                {
                    MyStore.Beverages.Add(new Beverage(name, p, Quantity));
                }
                else
                {
                    var obj = MyStore.Beverages.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + Quantity;
                    obj.Price = p;
                }
                break;
            case ProductItems.Fish:
                bool isExistFish = MyStore.Fishes.Any(x => x.Name == name);
                WriteLine($"How much kg {name} are there?");
                var kg = int.Parse(ReadLine());
                if (!isExistFish)
                {
                    MyStore.Fishes.Add(new Fish(name, p, kg));
                }
                else
                {
                    var obj = MyStore.Fishes.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + kg;
                    obj.Price = p;
                }
                break;
            case ProductItems.Meat:
                bool isExistMeat = MyStore.Meats.Any(x => x.Name == name);
                WriteLine($"How much kg {name} are there?");
                var kgMeat = int.Parse(ReadLine());
                if (!isExistMeat)
                {
                    MyStore.Meats.Add(new Meat(name, p, kgMeat));

                }
                else
                {
                    var obj = MyStore.Meats.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + kgMeat;
                    obj.Price = p;
                }
                break;
            case ProductItems.Milk:
                bool IsExistMilk = MyStore.Milks.Any(x => x.Name == name);
                WriteLine($"How many liters of {name} are there?");
                var liters = int.Parse(ReadLine());
                if (!IsExistMilk)
                {
                    MyStore.Milks.Add(new Milk(name, p, liters));

                }
                else
                {
                    var obj = MyStore.Milks.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + liters;
                    obj.Price = p;
                }
                break;
            case ProductItems.Vegetables:
                bool isExistVegetables = MyStore.VegetablesList.Any(x => x.Name == name);
                WriteLine($"How much kg {name} are there?");
                var kgVegetables = int.Parse(ReadLine());
                if (!isExistVegetables)
                {
                    MyStore.VegetablesList.Add(new Vegetables(name, p, kgVegetables));

                }
                else
                {
                    var obj = MyStore.VegetablesList.Find(x => x.Name == name);
                    obj.Quantity = obj.Quantity + kgVegetables;
                    obj.Price = p;
                }
                break;
        }
        ConsoleUtils.WaitForKeyPress();
        Run();
    }

}
