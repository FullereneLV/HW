using static System.Console;
using StoreInventorySystem.Staff;

namespace StoreInventorySystem.AllMenu;

public class LoginMenu : PatternMenu
{
    private List<People> _users = new();

    public LoginMenu(Store store) : base(store)
    {
    }

    public override void Run()
    {
        Clear();
        WriteLine("Use the arrow key to cycle through options and press enter to select an option");
        string prompt = "Welcome to Store Inventory System.";
        string[] options = { "Sing Up", "Sing In", "Exit" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();

        switch (selectedIndex)
        {
            case 0:
                SingUp();
                break;
            case 1:
                LogIn();
                break;
            case 2:
                ConsoleUtils.QuitConsole();
                break;
        }
        ConsoleUtils.WaitForKeyPress();
        Run();
    }

    private void SingUp()
    {
        Clear();
        WriteLine("Welcome to create account");
        WriteLine("Enter email:");
        var email = ReadLine();
        WriteLine("Enter password");
        var password = ReadLine();
        if (_users.Exists(u => u.Email == email))
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Username already exists. Please try logging in.");
            ResetColor();
        }
        else
        {
            WriteLine("Enter Name:");
            var name = ReadLine();
            _users.Add(new People(name, email, password));
            ForegroundColor = ConsoleColor.Green;
            WriteLine("User registered successfully.");
            ResetColor();
        }
    }

    private void LogIn()
    {
        Clear();
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Welcome to Log In:");
        ResetColor();
        WriteLine("Enter email:");
        var email = ReadLine();
        WriteLine("Enter password");
        var password = ReadLine();

        var user = _users.Find(u => u.Email == email && u.Password == password);
        if (user != null)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Login successful!");
            ResetColor();
            ConsoleUtils.WaitForKeyPress();
            MyStore.MyMenegerMenu.Run();
        }
        else
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Invalid credentials. Please try again.");
            ResetColor();
        }
    }
}
