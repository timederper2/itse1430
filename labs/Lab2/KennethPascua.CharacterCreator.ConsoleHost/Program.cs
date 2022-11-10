/*
 Kenneth V. Pascua
 Lab 2
 ITSE 1430, Fall 2022
 */

using KennethPascua.CharacterCreator;

Character character = null;
CharacterDatabase database = new CharacterDatabase();

bool quitDone = false;

DisplayInformation();

do
{
    var input = DisplayMenu();
    Console.WriteLine();
    switch (input)
    {
        case MenuOption.New:
        {
            var theCharacter = NewCharacter();
            character = theCharacter.Clone();
            break;

        }
        case MenuOption.View: ViewCharacter(); break;
        case MenuOption.Clear: ClearCharacter(); break;
        case MenuOption.Edit: EditCharacter(); break;
        case MenuOption.Quit: quitDone = true; break;
        case MenuOption.Error: DisplayErrorMessage(); break;
    }

    if (quitDone == true)
        quitDone = QuitConfirmation(quitDone);
} while (!quitDone);

MenuOption DisplayMenu ()
{
    Console.WriteLine();
    Console.WriteLine("".PadLeft(10, '-'));
    Console.WriteLine("Welcome to the Character Creation Wizard!");
    Console.WriteLine("Please select an option below: ");
    Console.WriteLine("".PadLeft(10, '-'));
    Console.WriteLine("");
    Console.WriteLine("N)ew Character");
    Console.WriteLine("V)iew Existing Character");
    Console.WriteLine("C)lear Existing Character");
    Console.WriteLine("E)dit Existing Character");
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
            case ConsoleKey.Q: return MenuOption.Quit;

            default: return MenuOption.Error;
        }
    } while (true);
}

void DisplayInformation ()
{
    DateTime thisDay = DateTime.Now;

    Console.WriteLine("Kenneth V. Pascua");
    Console.WriteLine("ITSE 1430");
    Console.WriteLine("Lab 2: Character Creation");
    Console.WriteLine(thisDay.ToString());
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

int ReadInt32 ( string message, int minimumValue, int maximumValue )
{
    Console.Write(message);

    do
    {
        string value = Console.ReadLine();
        if (Int32.TryParse(value, out var result))
        {
            if (result >= minimumValue && result <= maximumValue)
                return result;
        };

        Console.WriteLine("Value must be between " + minimumValue + " and " + maximumValue);
    } while (true);
}

string ReadString ( string message, bool required )
{
    Console.Write(message);

    while (true)
    {
        string value = Console.ReadLine();

        if (value != "" || !required)
            return value;

        Console.WriteLine("Value is required");
    };
}

string ReadStringClass ( string message, bool required )
{
    Console.Write(message);

    while (true)
    {
        string value = Console.ReadLine();

        if (value != "" || !required)
        {
            if (String.Equals(value, "Fighter"))
            {
                return value;
            }

            if (String.Equals(value, "Hunter"))
            {
                return value;
            }

            if (String.Equals(value, "Priest"))
            {
                return value;
            }

            if (String.Equals(value, "Rogue"))
            {
                return value;
            }

            if (String.Equals(value, "Wizard"))
            {
                return value;
            }

        }

        Console.WriteLine("Value is required and must be: Fighter, Hunter, Priest, Rogue, Wizard.");
    };
}

string ReadStringRace ( string message, bool required )
{
    Console.Write(message);

    while (true)
    {
        string value = Console.ReadLine();

        if (value != "" || !required)
        {
            if (String.Equals(value, "Dwarf"))
            {
                return value;
            }

            else if (String.Equals(value, "Elf"))
            {
                return value;
            }

            else if (String.Equals(value, "Gnome"))
            {
                return value;
            }

            else if (String.Equals(value, "Half-Elf"))
            {
                return value;
            }

            else if (String.Equals(value, "Human"))
            {
                return value;
            }

        }

        Console.WriteLine("Value is required and must be: Dwarf, Elf, Gnome, Half-Elf, Human.");
    };
}

void DisplayErrorMessage ()
{
    Console.WriteLine("Sorry, try again!");
}

Character NewCharacter()
{
    Character character = new Character("Newsian Summatelsius");

    character.Name = ReadString("Enter a name: ", true);
    character.Class = ReadStringClass("Enter a class: ", true);
    character.Race = ReadStringRace("Enter a race: ", true);
    character.Description = ReadString("Enter a description: ", false);

    character.Strength = ReadInt32("Enter a value for your character's Strength (must be a number): ", 1, 100);
    character.Intelligence = ReadInt32("Enter a value for your character's Intelligence (must be a number): ", 1, 100);
    character.Agility = ReadInt32("Enter a value for your character's Agility (must be a number): ", 1, 100);
    character.Constitution = ReadInt32("Enter a value for your character's Constitution (must be a number): ", 1, 100);
    character.Charisma = ReadInt32("Enter a value for your character's Charisma (must be a number): ", 1, 100);

    return character;
}

void ViewCharacter()
{
    if (character.Name == "")
    {
        Console.WriteLine("No character stored!");
        return;
    }

    Console.WriteLine("".PadLeft(10, '~'));
    Console.WriteLine("Name: " + character.Name);
    Console.WriteLine("Class: " + character.Class);
    Console.WriteLine("Race: " + character.Race);
    Console.WriteLine("Description: " + character.Description);
    Console.WriteLine("".PadLeft(10, '-'));
    Console.WriteLine("Strength: " + character.Strength);
    Console.WriteLine("Intelligence: " + character.Intelligence);
    Console.WriteLine("Agility: " + character.Agility);
    Console.WriteLine("Constitution: " + character.Constitution);
    Console.WriteLine("Charisma: " + character.Charisma);
    Console.WriteLine("".PadLeft(10, '~'));
}

void ClearCharacter()
{
    if (character.Name == "")
        return;

    if (ReadBoolean($"Are you sure you want to delete the character '{character.Name}' (Y/N)?"))
    {
        character.Name = "";
    }
        return;
}

void EditCharacter()
{
    while (character.Name == "")
    {
        Console.WriteLine("No character stored! Starting Character Creation.");
        NewCharacter();
    }

    bool isTrue = true;
    string value = "";
    do
    {
        Console.WriteLine("".PadLeft(10, '~'));
        Console.WriteLine("Your character is: ");
        Console.WriteLine("Name: " + character.Name);
        Console.WriteLine("Class: " + character.Class);
        Console.WriteLine("Race: " + character.Race);
        Console.WriteLine("Description: " + character.Description);
        Console.WriteLine("".PadLeft(10, '-'));
        Console.WriteLine("Strength: " + character.Strength);
        Console.WriteLine("Intelligence: " + character.Intelligence);
        Console.WriteLine("Agility: " + character.Agility);
        Console.WriteLine("Constitution: " + character.Constitution);
        Console.WriteLine("Charisma: " + character.Charisma);
        Console.WriteLine("".PadLeft(10, '~'));
    
        Console.WriteLine("What would you like to change?");
        Console.WriteLine("(Type 'Name', 'Class', 'Race', 'Description', 'Strength', ");
        Console.WriteLine("'Intelligence', 'Agility', 'Constitution', 'Charisma', or 'Nothing'.");
        value = Console.ReadLine();
        if (String.Equals(value, "Name"))
        {
            character.Name = ReadString("Enter a new name (required): ", true);
            character.Clone();
        } 
        
        else if (String.Equals(value, "Class"))
        {
            character.Class = ReadStringClass("Enter a new class (required): ", true);
            character.Clone();
        }

        else if (String.Equals(value, "Race"))
        {
            character.Race = ReadStringRace("Enter a new race (required): ", true);
            character.Clone();
        }

        else if (String.Equals(value, "Description"))
        {
            character.Description = ReadString("Enter a new description (optional): ", false);
            character.Clone();
        }

        else if (String.Equals(value, "Strength"))
        {
            character.Strength = ReadInt32("Enter a new value for your character's Strength (must be a number): ", 1, 100);
            character.Clone();
        }

        else if (String.Equals(value, "Intelligence"))
        {
            character.Intelligence = ReadInt32("Enter a new value for your character's Intelligence (must be a number): ", 1, 100);
            character.Clone();
        }

        else if (String.Equals(value, "Agility"))
        {
            character.Agility = ReadInt32("Enter a new value for your character's Agility (must be a number): ", 1, 100);
            character.Clone();
        }

        else if (String.Equals(value, "Constitution"))
        {
            character.Constitution = ReadInt32("Enter a new value for your character's Constitution (must be a number): ", 1, 100);
            character.Clone();
        }

        else if (String.Equals(value, "Charisma"))
        {
            character.Charisma = ReadInt32("Enter a new value for your character's Charisma (must be a number): ", 1, 100);
            character.Clone();
        }

        else if (String.Equals(value, "Nothing"))
        {
            return;
        }

        else
        {
            Console.WriteLine("Please enter a valid value!");
        }
        


    } while (isTrue);
}

bool QuitConfirmation ( bool done )
{
    Console.WriteLine("Are you sure you want to quit? (Y/N?)");
    ConsoleKeyInfo key = Console.ReadKey(done);
    var loop = true;

    do
    {
        switch (key.Key)
        {
            case ConsoleKey.Y: return true;
            case ConsoleKey.N: return false;

            default: return false;
        }
    } while (loop);
}