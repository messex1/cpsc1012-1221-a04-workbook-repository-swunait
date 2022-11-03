int numValues; // Actual number of values to process
int[] value = new int[MAX_NUM_VALUES]; // Array of integers
string userInput; // To hold user keyboard input value
                  // Prompt the user for the number of data items.
Console.Write("Enter the number of values to process: ");
userInput = Console.ReadLine();
numValues = int.Parse(userInput);
// Read in the data.
InputValues(value, numValues);
// Double the value of each data element.
DoubleValues(value, numValues);
// Display the data.
Console.WriteLine("Data doubled:");
DisplayValues(value, numValues);
Console.WriteLine();

// --------------------------------------------------------------------
static void InputValues(int[] data, int count)
{ // Read the values into an array
    Console.WriteLine("Enter the data: ");
    string userInput; // To hold user keyboard input value
    for (int index = 0; index < count; index++)
    {
        userInput = Console.ReadLine();
        data[index] = int.Parse(userInput);
    }
}

// --------------------------------------------------------------------
 static void DoubleValues(int[] data, int count)
{ // Double the values in the array
    for (int index = 0; index < count; index++)
    {
        data[index] = data[index] * 2;
    }
}

// --------------------------------------------------------------------
static void DisplayValues(int[] data, int count)
{ // Display the values in the array.
    for (int index = 0; index < count; index++)
    {
        if (index % MAX_PER_LINE == 0)
        {
            Console.WriteLine();
        }
        Console.Write($"{data[index]}");
    }
}

public partial class Program
{
    const int MAX_NUM_VALUES = 20; // Max number of data values
    const int MAX_PER_LINE = 5; // Max values per line to display

}