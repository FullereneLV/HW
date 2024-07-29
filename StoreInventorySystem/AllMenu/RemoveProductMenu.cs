using StoreInventorySystem.AllMenu;
using static System.Console;

namespace StoreInventorySystem;

public class RemoveProductMenu
{
    protected Store MySrote;

    public RemoveProductMenu(Store menu){
        MySrote = menu;
    }
    public void RemoveMenu(){
        Clear();
        string prompt = "Remove product:";
        string[] options = { "Beverage", "Fish", "Meat", "Milk", "Vegetables", "Back to Meneger menu" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

        switch (selectedIndex)
        {
             case 0:
                MySrote.Remove(ProductItems.Beverage);
                break;
            case 1:
                MySrote.Remove(ProductItems.Fish);
                break;
            case 2:
                MySrote.Remove(ProductItems.Meat);
                break;
            case 3:
                MySrote.Remove(ProductItems.Milk);
                break;
            case 4:
                MySrote.Remove(ProductItems.Vegetables);
                break;
            case 5:
                MySrote.menegerMenu.RunMenegerMenu();
                break;
        }
    }
}
