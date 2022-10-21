
int menuOptionChoice;
const int MinMenuChoice = 0;
const int MaxMenuChoice = 4;
const int ExitProgramChoice = 0;

do
{

    // Prompt for menu choice
    menuOptionChoice = GetMainMenuChoice(MinMenuChoice, MaxMenuChoice);
    // Process the menu choice
    switch (menuOptionChoice)
    {
        case 1:
            {
                double price = TicketPrice(menuOptionChoice);
                Console.WriteLine($"Children ticket price {price:C}");
            }
            break;
        case 2:
            {
                double price = TicketPrice(menuOptionChoice);
                Console.WriteLine($"Students ticket price {price:C}");
            }
                break;
        case 3:
            {
                double price = TicketPrice(menuOptionChoice);
                Console.WriteLine($"Adults ticket price {price:C}");
            }
                break;
        case 4:
            {
                double price = TicketPrice(menuOptionChoice);
                Console.WriteLine($"Seniors ticket price {price:C}");
            }
            break;
        case 0:
            Console.WriteLine("Good bye");
            break;
        default:
            Console.WriteLine("Logical error in code");
            break;

    }

} while (menuOptionChoice != ExitProgramChoice);

static double TicketPrice(int option)
{
    double price = 0.00;

    if (option == 1)
    {
        price = 0.00;
    }
    else if (option == 2)
    {
        price = 9.80;
    }
    else if (option == 3)
    {
        price = 11.35;
    }
    else if (option == 4)
    {
        price = 10.00;
    }
    else
    {
        Console.WriteLine("Logical error in code");
    }

    return price;
}

static int GetMainMenuChoice(int minValue, int maxValue)
{
    int menuChoice = 0;
    bool validInput = false;

    while (!validInput)
    {
        DisplayMainMenu();
        try
        {
            menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice >= minValue && menuChoice <= maxValue)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine($"Invalid menu choice. Must be between {minValue} and {maxValue}.");
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Invalid input. Please enter a integer number.");
        }
    } 

    return menuChoice;
}

static void DisplayMainMenu()
{
    const string MainMenuOptions = @"
*** Movie Theatre Admission Prices ***

1.  Children 6 and under = FREE ($.00)
2.  Students 7 to 17 = $9.80
3.  Adults 18 to 54 = $11.35
4.  Seniors 55+ = $10.00
0.  Exit program.
Your choice >> ";
    Console.Write(MainMenuOptions);
}


