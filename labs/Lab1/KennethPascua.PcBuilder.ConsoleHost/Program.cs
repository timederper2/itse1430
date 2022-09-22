
DisplayInformation();
int price = 0;
int processorValue = 0;
int memoryValue = 0;
int primaryStorageValue = 0;
int secondaryStorageValue = 0;
int graphicsValue = 0;
int osValue = 0;
string primaryStorageName = "";
string secondaryStorageName = "";
string graphicsName = "";
string osName = "";
string processorName = "";
string memoryName = "";
var done = false;
bool isOrder = false;

do
{
    RunningPrice();
    var input = DisplayMenu();
    Console.WriteLine();
    switch (input)
    {
        case MenuOption.New: NewOrder(); break;
        case MenuOption.View: ViewOrder(); break;
        case MenuOption.Clear: ClearOrder(); break;
        case MenuOption.Edit: EditOrder(); break;
        case MenuOption.Quit: done = true; break;
        case MenuOption.Error: DisplayErrorMessage(); break;
    }
    if (done == true)
        done = QuitConfirmation(done);
} while (!done);

//Here be Functions

void DisplayInformation ()
{
    DateTime thisDay = DateTime.Now;

    Console.WriteLine("Kenneth V. Pascua");
    Console.WriteLine("ITSE 1430");
    Console.WriteLine(thisDay.ToString());
}
bool QuitConfirmation (bool done)
{
    Console.WriteLine("Are you sure you want to quit? (Y/N?)");
    ConsoleKeyInfo key = Console.ReadKey(true);
    var loop = true;

    do
    {
        switch (key.Key)
        {
            case ConsoleKey.Y: return true;
            case ConsoleKey.N: return false; 

            default : return false;
        }
    } while (loop);
}
void DisplayErrorMessage ()
{
    Console.WriteLine("Sorry, try again!");
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
    Console.WriteLine("Q)uit");
    Console.WriteLine("Current Order Price: $" + price);
    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.N: return MenuOption.New;
            case ConsoleKey.V: return MenuOption.View;
            case ConsoleKey.C: return MenuOption.Clear;
            case ConsoleKey.E: return MenuOption.Edit;
            case ConsoleKey.Q: return MenuOption.Quit;

            default: return MenuOption.Error;
        }
    }while (true);
}
void NewOrder ()
{
    RunningPrice();
    bool isTrue = true;
    isOrder = true;

    processorName = processorChoice("Decide your processor: ");

    do
    {
        if (processorName == "")
        {
            processorName = processorChoice("Decide your processor: ");
        } else
            isTrue = false;
    }while (isTrue);
    
    isTrue = true;

    memoryName = memoryChoice("Decide your memory: ");

    do
    {
        if (memoryName == "")
        {
            memoryName = memoryChoice("Decide your memory: ");
        } else
            isTrue = false;
    } while (isTrue);

    isTrue = true;

    primaryStorageName = primaryStorageChoice("Decide your primary storage: ");

    do
    {
        if (primaryStorageName == "")
        {
            primaryStorageName = primaryStorageChoice("Decide your primary storage: ");
        } else
            isTrue = false;
    } while (isTrue);

    isTrue = true;

    secondaryStorageName = secondaryStorageChoice("Decide your secondary storage: ");

    do
    {
        if (secondaryStorageName == "")
        {
            secondaryStorageName = secondaryStorageChoice("Decide your secondary storage: ");
        } else
            isTrue = false;
    } while (isTrue);

    isTrue = true;

    graphicsName = graphicsChoice("Decide your graphics card: ");

    do
    {
        if (graphicsName == "")
        {
            graphicsName = graphicsChoice("Decide your graphics card: ");
        } else
            isTrue = false;
    } while (isTrue);

    isTrue = true;

    osName = osChoice("Decide your operating system: ");

    do
    {
        if (osName == "")
        {
            osName = osChoice("Decide your operating system: ");
        } else
            isTrue = false;
    } while (isTrue);

    isTrue = true;

}

void ViewOrder()
{
    if (processorName ==  "" || isOrder == false)
    {
        Console.WriteLine("No order available!");
        return;
    }
    Console.WriteLine("");
    Console.WriteLine("Processor: " + processorName + "  $" + processorValue);
    Console.WriteLine("Memory: " + memoryName + "  $" + memoryValue);
    Console.WriteLine("Primary Storage: " + primaryStorageName + "  $" + primaryStorageValue);
    Console.WriteLine("Secondary Storage: " + secondaryStorageName + "  $" + secondaryStorageValue);
    Console.WriteLine("Graphics Card: " + graphicsName + "  $" + graphicsValue);
    Console.WriteLine("Operating System: " + osName + "  $" + osValue);
    Console.WriteLine("");
}
void ClearOrder()
{
    if (processorName == "" || isOrder || false)
        return;
    if (ReadBoolean("Are you sure you want to delete this movie (Y/N)? "))
    {
        processorName = "";
        memoryName = "";
        processorValue = 0;
        memoryValue = 0;
        isOrder = false;
    }
        return;
}

void EditOrder ()
{
    if (isOrder == false)
    {
        Console.WriteLine("No order detected!");
        return;
    }
    bool isTrue = true;
    Console.WriteLine("Currently Selected Processor: " + processorName);
    Console.WriteLine("Currently Selected Memory: " + memoryName);
    Console.WriteLine("Currently Selected Primary Storage (Hard Drive): " + primaryStorageName);
    Console.WriteLine("Currently Selected Secondary Storage: " + secondaryStorageName);
    Console.WriteLine("Currently Selected Graphics Card: " + graphicsName);
    Console.WriteLine("Currently Selected Operating System: " + osName);
    Console.WriteLine("");
    Console.WriteLine("Select order elements to modify: ");
    Console.WriteLine("P)rocessor");
    Console.WriteLine("M)emory");
    Console.WriteLine("H)ard Drive");
    Console.WriteLine("S)econdary Memory");
    Console.WriteLine("G)raphics Card");
    Console.WriteLine("O)perating System");
    Console.WriteLine("N)othing");

    ConsoleKeyInfo key = Console.ReadKey(true);

   while (isTrue)
    {

        switch (key.Key)
        {
            case ConsoleKey.P: processorChoice("Select new processor: "); return;
            case ConsoleKey.M: memoryChoice ("Select new memory: "); return;
            case ConsoleKey.H: primaryStorageChoice("Select new hard drive: "); return;
            case ConsoleKey.S: secondaryStorageChoice("Select new backup drive: "); return;
            case ConsoleKey.G: graphicsChoice("Select new graphics card: "); return;
            case ConsoleKey.O: osChoice("Select new operating system: "); return;
            case ConsoleKey.N: return ;
         
        }

    };


}

bool ReadBoolean ( string message )
{
    Console.Write(message);

    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Y)
            return true;
        else if (key.Key == ConsoleKey.N)
            return false;
    } while (true);
}

string processorChoice ( string message)
{
    price = 0;
    isOrder = true;
    Console.WriteLine("");
    Console.WriteLine(message);
    Console.WriteLine("A) AMD Ryzen 9 5900X ($1410)");
    Console.WriteLine("B) AMD Ryzen 7 5700X ($1270)");
    Console.WriteLine("C) AMD Ryzen 5 5600X ($1200)");
    Console.WriteLine("D) Intel i9-12900K ($1590)");
    Console.WriteLine("E) Intel i7-12700K ($1400)");
    Console.WriteLine("F) Intel i5-12600K ($1280)");

    ConsoleKeyInfo key = Console.ReadKey(true);

    while (true)
    {
        switch (key.Key)
        {
            case ConsoleKey.A: return processorName = "AMD Ryzen 9 5900X";
            case ConsoleKey.B: return processorName = "AMD Ryzen 7 5700X";
            case ConsoleKey.C: return processorName = "AMD Ryzen 5 5600X";
            case ConsoleKey.D: return processorName = "Intel i9-12900K";
            case ConsoleKey.E: return processorName = "Intel i7-12700K";
            case ConsoleKey.F: return processorName = "Intel i5-12600K";
            default: Console.WriteLine("Enter a valid value"); return processorName;
        }
    };
}

string memoryChoice ( string message)
{
    Console.WriteLine("");
    Console.WriteLine(message);
    Console.WriteLine("A) 8 GB ($30)");
    Console.WriteLine("B) 16 GB ($40)");
    Console.WriteLine("C) 32 GB ($90)");
    Console.WriteLine("D) 64 GB ($410)");
    Console.WriteLine("E) 128 GB ($600)");

    ConsoleKeyInfo key = Console.ReadKey(true);

    while (true)
    {
        switch (key.Key)
        {
            case ConsoleKey.A: return memoryName = "8 GB";
            case ConsoleKey.B: return memoryName = "16 GB";
            case ConsoleKey.C: return memoryName = "32 GB";
            case ConsoleKey.D: return memoryName = "64 GB";
            case ConsoleKey.E: return memoryName = "128 GB";
            default : Console.WriteLine("Enter a valid value"); return memoryName;
        }
    };
}

string primaryStorageChoice( string message)
{
    Console.WriteLine("");
    Console.WriteLine(message);
    Console.WriteLine("A) SSD 256 GB ($90)");
    Console.WriteLine("B) SSD 512 GB ($100)");
    Console.WriteLine("C) SSD 1 TB ($125)");
    Console.WriteLine("D) SSD 2 TB ($230)");

    ConsoleKeyInfo key = Console.ReadKey(true);

    while (true)
    {
        string value = "";
        switch (key.Key)
        {
            case ConsoleKey.A: return value = "SSD 256 GB";
            case ConsoleKey.B: return value = "SSD 512 GB";
            case ConsoleKey.C: return value = "SSD 1 TB";
            case ConsoleKey.D: return value = "SSD 2 TB";
            default: Console.WriteLine("Enter a valid value"); return value;
        }
    };

} 

string secondaryStorageChoice( string message)
    {
        Console.WriteLine("");
        Console.WriteLine(message);
        Console.WriteLine("A) None ($0)");
        Console.WriteLine("B) HDD 1 TB ($40)");
        Console.WriteLine("C) HDD 2 TB ($50)");
        Console.WriteLine("D) HDD 4 TB ($70)");
        Console.WriteLine("E) SSD 512 GB ($100)");
        Console.WriteLine("F) SSD 1 TB ($125)");
        Console.WriteLine("G) SSD 2 TB ($230)");

        ConsoleKeyInfo key = Console.ReadKey(true);

        while (true)
        {
            string value = "";
            switch (key.Key)
            {
                case ConsoleKey.A: return value = "None";
                case ConsoleKey.B: return value = "HDD 1 TB";
                case ConsoleKey.C: return value = "HDD 2 TB";
                case ConsoleKey.D: return value = "HDD 4 TB";
                case ConsoleKey.E: return value = "SSD 512 GB";
                case ConsoleKey.F: return value = "SSD 1 TB";
                case ConsoleKey.G: return value = "SSD 2 TB";
                default: Console.WriteLine("Enter a valid value"); return value;
            }
        }
    }

string graphicsChoice ( string message)
{
    Console.WriteLine("");
    Console.WriteLine(message);
    Console.WriteLine("A) None ($0)");
    Console.WriteLine("B) GeForce RTX 3070 ($580)");
    Console.WriteLine("C) GeForce RTX 2070 ($400)");
    Console.WriteLine("D) Radeon RX 6600 ($300)");
    Console.WriteLine("E) Radeon RX 5600 ($325)");

    ConsoleKeyInfo key = Console.ReadKey(true);

    while (true)
    {
        string value = "";
        switch (key.Key)
        {
            case ConsoleKey.A: return value = "None";
            case ConsoleKey.B: return value = "GeForce RTX 3070";
            case ConsoleKey.C: return value = "GeForce RTX 2070";
            case ConsoleKey.D: return value = "Radeon RX 6600";
            case ConsoleKey.E: return value = "Radeon RX 5600";
            default: Console.WriteLine("Enter a valid value"); return value;
        }
    }
}

string osChoice ( string message)
{
    Console.WriteLine("");
    Console.WriteLine(message);
    Console.WriteLine("A) Windows 11 Home ($140)");
    Console.WriteLine("B) Windows 11 Pro ($110)");
    Console.WriteLine("C) Windows 10 Home ($150)");
    Console.WriteLine("D) Windows 10 Pro ($170)");
    Console.WriteLine("E) Linux (Fedora) ($20)");
    Console.WriteLine("F) Linux (Red Hat) ($60)");

    ConsoleKeyInfo key = Console.ReadKey(true);

    while (true)
    {
        string value = "";
        switch (key.Key)
        {
            case ConsoleKey.A: return value = "Windows 11 Home";
            case ConsoleKey.B: return value = "Windows 11 Pro";
            case ConsoleKey.C: return value = "Windows 10 Home";
            case ConsoleKey.D: return value = "Windows 10 Pro";
            case ConsoleKey.E: return value = "Linux (Fedora)";
            case ConsoleKey.F: return value = "Linux (Red Hat)";
            default: Console.WriteLine("Enter a valid value"); return value;
        }
    }
}

int RunningPrice ()
{
    if (processorName == "AMD Ryzen 9 5900X")
        processorValue = 1410;
    else if (processorName == "AMD Ryzen 7 5700X")
        processorValue = 1270;
    else if (processorName == "AMD Ryzen 5 5600X")
        processorValue = 1200;
    else if (processorName == "Intel i9-12900K")
        processorValue = 1590;
    else if (processorName == "Intel i7-12700K")
        processorValue = 1400;
    else if (processorName == "Intel i5-12600K")
        processorValue = 1280;

    if (memoryName == "8 GB")
        memoryValue = 30;
    else if (memoryName == "16 GB")
        memoryValue = 40;
    else if (memoryName == "32 GB")
        memoryValue = 90;
    else if (memoryName == "64 GB")
        memoryValue = 410;
    else if (memoryName == "128 GB")
        memoryValue = 600;

    if (primaryStorageName == "SSD 256 GB")
        primaryStorageValue = 90;
    else if (primaryStorageName == "SSD 512 GB")
        primaryStorageValue = 100;
    else if (primaryStorageName == "SSD 1 TB")
        primaryStorageValue = 125;
    else if (primaryStorageName == "SSD 2 TB")
        primaryStorageValue = 230;

    if (secondaryStorageName == "None")
        secondaryStorageValue = 0;
    else if (secondaryStorageName == "HDD 1 TB")
        secondaryStorageValue = 40;
    else if (secondaryStorageName == "HDD 2 TB")
        secondaryStorageValue = 50;
    else if (secondaryStorageName == "HDD 4 TB")
        secondaryStorageValue = 70;
    else if (secondaryStorageName == "SSD 512 GB")
        secondaryStorageValue = 100;
    else if (secondaryStorageName == "SSD 1 TB")
        secondaryStorageValue = 125;
    else if (secondaryStorageName == "SSD 2 TB")
        secondaryStorageValue = 230;

    if (graphicsName == "None")
        graphicsValue = 0;
    else if (graphicsName == "GeForce RTX 3070")
        graphicsValue = 580;
    else if (graphicsName == "GeForce RTX 2070")
        graphicsValue = 400;
    else if (graphicsName == "Radeon RX 6600")
        graphicsValue = 300;
    else if (graphicsName == "Radeon RX 5600")
        graphicsValue = 325;

    if (osName == "Windows 11 Home")
        osValue = 140;
    else if (osName == "Windows 11 Pro")
        osValue = 160;
    else if (osName == "Windows 10 Home")
        osValue = 150;
    else if (osName == "Windows 10 Pro")
        osValue = 170;
    else if (osName == "Linux (Fedora)")
        osValue = 20;
    else if (osName == "Linux (Red Hat)")
        osValue = 60;

    price = processorValue + memoryValue + primaryStorageValue + secondaryStorageValue + graphicsValue + osValue;
    return price;
}