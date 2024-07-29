namespace StoreInventorySystem;

public static class ConsoleUtils
{
    public static string FormatStringTable = "{0,-20}{1,-20}{2,-20}";
    public static string FormatStringQuantity = "{0,-40}{1,-20}";
    
    public static void WaitForKeyPress()
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey(true);
    }

    public static void QuitConsole()
    {
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(true);
        Environment.Exit(0);
    }


}
