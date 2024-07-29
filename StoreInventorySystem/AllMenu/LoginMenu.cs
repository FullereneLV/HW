using static System.Console;
using StoreInventorySystem.AllMenu;

namespace StoreInventorySystem;

public class LoginMenu
{
    List<People> users = new List<People>();
    MenegerMenu menegerMenu;

    public LoginMenu(Store store){
        menegerMenu = new MenegerMenu(store);
    }
    
    public void Start()
    {
        RunLoginMenu();
    }

    private void RunLoginMenu(){
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
                ExitApp();
                break;
        }
    }

    private void SingUp(){
        Clear();
        WriteLine("Welcome to create account");
        
        WriteLine("Enter email:");
        var email = ReadLine();
        WriteLine("Enter password");
        var password = ReadLine();
        if (users.Exists(u => u.Email == email))
        {
           ForegroundColor = ConsoleColor.Red;
            WriteLine("Username already exists. Please try logging in.");
            ResetColor();
        }
        else
        {
            WriteLine("Enter Name:");
            var name = ReadLine();
            WriteLine();

            users.Add(new People(name, email, password));
            ForegroundColor = ConsoleColor.Green;
            WriteLine("User registered successfully.");
            ResetColor();
            ConsoleUtils.WaitForKeyPress();
            RunLoginMenu();
        }
        WriteLine("Press any key to exit ...");
        ReadKey(true);
        RunLoginMenu();
    }

    private void LogIn(){
        Clear();
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Welcome to Log In:");
        ResetColor();
        WriteLine("Enter email:");
        var email =ReadLine();
        WriteLine("Enter password");
        var password = ReadLine();

        var user = users.Find(u => u.Email == email && u.Password == password);
        if (user != null)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Login successful!");
            ResetColor();
            ConsoleUtils.WaitForKeyPress();
            menegerMenu.RunMenegerMenu();
        }
        else
        {
           ForegroundColor = ConsoleColor.Red;
            WriteLine("Invalid credentials. Please try again.");
            ResetColor();
            ConsoleUtils.WaitForKeyPress();
            RunLoginMenu();
        }
    }
    
    private void ExitApp(){
        WriteLine("Press any key to exit ...");
        ReadKey(true);
        Environment.Exit(0);
    }
}
