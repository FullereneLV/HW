using StoreInventorySystem.AllMenu;
using StoreInventorySystem.AllProducts;

namespace StoreInventorySystem;

public class Store
{
    public List<Beverage> Beverages = new();
    public List<Fish> Fishes = new();
    public List<Meat> Meats = new();
    public List<Milk> Milks = new();
    public List<Vegetables> VegetablesList = new();
    public MenegerMenu MyMenegerMenu;
    public RemoveProductMenu MyRemoveProductMenu;
    public AddProductMenu MyAddProductMenu;
    public ShowProduct MyShowProduct;
    public LoginMenu MyLoginMenu;
    public Store()
    {
        MyMenegerMenu = new MenegerMenu(this);
        MyLoginMenu = new LoginMenu(this);
        MyRemoveProductMenu = new RemoveProductMenu(this);
        MyAddProductMenu = new AddProductMenu(this);
        MyShowProduct = new ShowProduct(this);
    }

    public void Run()
    {
        MyLoginMenu.Run();
    }
}
