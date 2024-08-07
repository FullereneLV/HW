using static System.Console;

namespace StoreInventorySystem.AllMenu;

public class MenegerMenu : PatternMenu
{
    public MenegerMenu(Store store):base(store)
    {
    }

    public override void Run()
    {
        Clear();
        string prompt = " Welcome to Meneger Menu:";
        string[] options = { "Add product", "Remove product", "Show product", "Log Out" };
        var menu = new Menu(prompt, options);
        var selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
                MyStore.MyAddProductMenu.Run();
                break;
            case 1:
                MyStore.MyRemoveProductMenu.Run();
                break;
            case 2:
                MyStore.MyShowProduct.Run();
                break;
            case 3:
                MyStore.MyLoginMenu.Run();
                break;
        }
    }
}
