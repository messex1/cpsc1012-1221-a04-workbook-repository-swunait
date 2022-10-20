//PrintColumnNumbers(5);
//PrintColumnNumbers(15);
//PrintColumnNumbers(25);
//PrintColumnNumbers(30);

MoveCharacter('o', 25, 100);


static void PrintColumnNumbers(int maxColumns)
{
    int currentColumnNumber = 1;
    for (int currentColumn = 1;
     currentColumn <= maxColumns;
     currentColumn++)
    {
        if (currentColumnNumber == 10)
        {
            currentColumnNumber = 0;
        }
        Console.Write(currentColumnNumber);
        currentColumnNumber += 1;
    }
    Console.WriteLine();
}

static void MoveCharacter(
    char animationChar,
    int maxColumns,
    int animationMillisecondsDelay)
{
    for (int currentColumn = 1;
     currentColumn <= maxColumns;
     currentColumn++)
    {
        Console.Clear();
        PrintColumnNumbers(maxColumns);
        Console.Write($"{animationChar}".PadLeft(currentColumn));
        Thread.Sleep(animationMillisecondsDelay);
    }
}

