double cups; // To hold the number of cups.
double ounces; // To hold the number of ounces.
// Get the number of cups.
cups = GetCups();

// Convert the cups to fluid ounces
ounces = CupsToOunces(cups);

// Display the results.
DisplayResults(cups, ounces);

static void DisplayResults(double cups, double ounces)
{
    // Display the number of cups
    Console.WriteLine($"{cups} cups equals {ounces} fluid ounces.");
}

static double CupsToOunces(double cups)
{
    double ounces = 0;
    ounces = cups * 8.0;
    return ounces;
}

static double GetCups()
{
    double cups = 0;

    string promptMessage = @"This program converts measurements in cups to fluid ounces.
For your reference the formula is:
    1 cup = 8 fluid ounces.
Enter the number of cups: ";

    //Console.Write(promptMessage);
    //cups = double.Parse(Console.ReadLine());
    cups = PromptForDoubleValue(promptMessage);

    return cups;
}

static double PromptForDoubleValue(string promptMessage)
{
    double doubleValue = 0;

    //bool validInput = false;
    //while (!validInput)
    //{
    //    Console.Write(promptMessage);
    //    try
    //    {
    //        doubleValue = double.Parse(Console.ReadLine());
    //        validInput = true;
    //    }
    //    catch//(Exception ex)
    //    {
    //        Console.WriteLine("Invalid input value. Please enter a number.");
    //    }
    //}

    Console.Write(promptMessage);
    while ( ! double.TryParse(Console.ReadLine(), out doubleValue))
    {
        Console.WriteLine("Invalid input value. Please enter a number.");
        Console.Write(promptMessage);
    }

    return doubleValue;
}

