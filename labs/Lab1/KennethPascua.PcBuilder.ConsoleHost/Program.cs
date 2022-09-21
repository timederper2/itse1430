
DisplayInformation();
var done = false;

do
{
    var input = DisplayMenu();
    Console.WriteLine();
    switch (input)
    {
        //case MenuOption.New: NewOrder(); break;
        //case MenuOption.View: ViewOrder(); break;
        //case MenuOption.Clear: ClearOrder(); break;
        //case MenuOption.Edit: EditOrder(); break;
        case MenuOption.Quit: done = true; break;

        default: break;
    }
} while (!done);

void DisplayInformation ()
{
    DateTime thisDay = DateTime.Now;

    Console.WriteLine("Kenneth V. Pascua");
    Console.WriteLine("ITSE 1430");
    Console.WriteLine(thisDay.ToString());
}

MenuOption DisplayMenu ()
{
    Console.WriteLine();
    Console.WriteLine("".PadLeft(10, '-'));
    Console.WriteLine("Welcome to the Zell PC Storefront!");
    Console.WriteLine("Please select an option below: ");
    Console.WriteLine("".PadLeft(10, '-'));
    Console.WriteLine("");
    Console.WriteLine("N)ew Order");
    Console.WriteLine("V)iew Existing Order");
    Console.WriteLine("C)lear Existing Order");
    Console.WriteLine("E)dit Existing Order");
    Console.WriteLine("A)dd to Existing Order");
    Console.WriteLine("Q)uit");

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.N: return MenuOption.New;
            case ConsoleKey.V: return MenuOption.View;
            case ConsoleKey.C: return MenuOption.Clear;
            case ConsoleKey.E: return MenuOption.Edit;
            case ConsoleKey.A: return MenuOption.Add;
            case ConsoleKey.Q: return MenuOption.Quit;
        }
    }while (true);
}
