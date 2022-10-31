const int POLLUTION_ARRAY_SIZE = 6;
// Array of six pollution level readings
int[] pollutionLevel = new int[POLLUTION_ARRAY_SIZE];
string userInput; // To hold user keyboard input value
                  // Input six integers into the pollution level array.
Console.WriteLine("Enter the six pollution level readings: ");
for (int index = 0; index < POLLUTION_ARRAY_SIZE; index++)
{
    userInput = Console.ReadLine();
    pollutionLevel[index] = int.Parse(userInput);
}
// Display the readings three values per line.
for (int index = 0; index < POLLUTION_ARRAY_SIZE; index++)
{
    if (index % 3 == 0)
    {
        Console.WriteLine();
    }
    Console.Write($"{pollutionLevel[index]} ");
}
Console.WriteLine();
