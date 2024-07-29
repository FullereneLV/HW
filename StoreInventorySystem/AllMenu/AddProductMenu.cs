using StoreInventorySystem.AllMenu;
using static System.Console;

namespace StoreInventorySystem;

public class AddProductMenu
{
    protected Store MySrote;

    public AddProductMenu(Store menu){
        MySrote = menu;
    }
    public void AddMenu(){
        Clear();
        string prompt = "Add product:";
        string[] options = { "Beverage", "Fish", "Meat", "Milk", "Vegetables", "Back to Meneger menu" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
                MySrote.AddProduct(ProductItems.Beverage);
                break;
            case 1:
                MySrote.AddProduct(ProductItems.Fish);
                break;
            case 2:
                MySrote.AddProduct(ProductItems.Meat);
                break;
            case 3:
                MySrote.AddProduct(ProductItems.Milk);
                break;
            case 4:
                MySrote.AddProduct(ProductItems.Vegetables);
                break;
            case 5:
                MySrote.menegerMenu.RunMenegerMenu();
                break;
        }
    }

}
