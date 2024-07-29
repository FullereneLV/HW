
using static System.Console;
namespace StoreInventorySystem.AllMenu;

public class Menu
{
    private int SelectedIndex;
    private string[] Options;
    private string Prompt;

    public Menu(string prompt, string[] options)
    {
        SelectedIndex = 0;
        Prompt = prompt;
        Options = options;
    }

    private void DisplayOptions(){
        WriteLine(Prompt);
        for (int i = 0; i < Options.Length; i++)
        {
            string currentOption = Options[i];
            string prefix;
            if (i == SelectedIndex)
            {
                prefix = "---> ";
            }
            else
            {
                prefix = "     ";
            }
            WriteLine($"{prefix}{currentOption}");
        }
    }

    public int Run()
    {
        ConsoleKey keyPressed;
        do
        {
            Clear();
            DisplayOptions();
            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {
                SelectedIndex--;
                if (SelectedIndex == -1)
                {
                    SelectedIndex = Options.Length - 1;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                SelectedIndex++;
                if (SelectedIndex == Options.Length)
                {
                    SelectedIndex = 0;
                }
            }
        } while (keyPressed != ConsoleKey.Enter);

        return SelectedIndex;
    }
}
