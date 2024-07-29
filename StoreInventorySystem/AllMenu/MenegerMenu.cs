using static System.Console;
namespace StoreInventorySystem.AllMenu;

public class MenegerMenu
{
    protected Store MySrote;
    AddProductMenu addProductMenu;
    RemoveProductMenu removeProductMenu;
    ShowProduct showProduct;
    public MenegerMenu(Store menu){
        MySrote = menu;
        addProductMenu = new AddProductMenu(menu);
        removeProductMenu = new RemoveProductMenu(menu);
        showProduct = new ShowProduct(menu);
    }
    public void RunMenegerMenu()
    {
        Clear();
        string prompt = " Welcome to Meneger Menu:";
        string[] options = { "Add product", "Remove product", "Show product", "Log Out" };
        var menu = new Menu(prompt, options);
        var selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
            addProductMenu.AddMenu();
                break;
            case 1:
            removeProductMenu.RemoveMenu();
                break;
            case 2:
            showProduct.ShowProductMenu();
                break;
            case 3:
                MySrote.loginMenu.Start();
                break;
        }
    }
}
