// Declare and create a new array that can store up to 25 numbers
const int MaxStudents = 5;
int[] numberArray = new int[MaxStudents];
// Declare a variable to track the number of marks entered
int markCount = 0;
// Repeatly prompt and read in a number and store it in the array
// until the input is the sentinel value of a negative number
Console.Write("Enter a number (non-number stop:)");
bool endOfInput = false;
while (!endOfInput)
{
    try
    {
        int number = int.Parse(Console.ReadLine());
        numberArray[markCount] = number;
        markCount++;
        if (markCount >= MaxStudents)
        {
            endOfInput = true;
            Console.WriteLine("Array is full");
        }
        else
        {
            Console.Write("Enter a number (non-number stop:)");
        }
    }
    catch(FormatException)
    {
        endOfInput = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
// Call the Average() method to get average of the numbers
double meanAverage = Average(numberArray, markCount);
// Display the meanAverage
Console.WriteLine($"The mean average of {markCount} numbers is {meanAverage}");

static double Average(int[] numberArray, int numberCount)
{
    double averageValue = 0;
    int sum = 0;

    for (int index = 0; index < numberCount; index++)
    {
        sum = sum + numberArray[index];
    }
    averageValue = sum / numberCount;    

    return averageValue;
}