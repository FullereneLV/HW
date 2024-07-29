using StoreInventorySystem.AllMenu;
using static System.Console;

namespace StoreInventorySystem;

public class ShowProduct
{
    protected Store MySrote;
    public ShowProduct(Store menu){
        MySrote = menu;
    }
public void ShowProductMenu(){
        Clear();
        string prompt = "Show product:";
        string[] options = { "Beverage", "Fish", "Meat", "Milk", "Vegetables", "Back to Meneger menu" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

       switch (selectedIndex)
        {
             case 0:
                MySrote.ShowProduct(ProductItems.Beverage);
                break;
            case 1:
                MySrote.ShowProduct(ProductItems.Fish);
                break;
            case 2:
                MySrote.ShowProduct(ProductItems.Meat);
                break;
            case 3:
                MySrote.ShowProduct(ProductItems.Milk);
                break;
            case 4:
                MySrote.ShowProduct(ProductItems.Vegetables);
                break;
            case 5:
                MySrote.menegerMenu.RunMenegerMenu();
                break;
        }
    }
}
