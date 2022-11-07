// Declare and create a new array that can store up to 25 numbers
using System.Globalization;

const int MaxStudents = 5;
int[] numberArray = new int[MaxStudents];
// Call the GetUserNumbers() method
int markCount = GetUserNumbers(numberArray);
// Call the Average() method to get average of the numbers
int meanAverage = MeanAverageOfNumbers(numberArray, markCount);
// Display the meanAverage
Console.WriteLine($"The mean average of {markCount} numbers is {meanAverage}");

static int GetUserNumbers(int[] numbers)
{
    int count = 0;
    // Repeatly prompt and read in a number and store it in the array
    // until the input is the sentinel value of a negative number
    Console.Write("Enter a number (non-number stop:)");
    bool endOfInput = false;
    while (!endOfInput)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            numbers[count] = number;
            count++;
            if (count >= numbers.Length)
            {
                endOfInput = true;
                Console.WriteLine("Array is full");
            }
            else
            {
                Console.Write("Enter a number (non-number stop:)");
            }
        }
        catch (FormatException)
        {
            endOfInput = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    return count;
}

static int MeanAverageOfNumbers(int[] numbers, int count)
{
    int averageValue = 0;
    int sum = 0;

    for (int index = 0; index < count; index++)
    {
        sum = sum + numbers[index];
    }
    averageValue = sum / count;

    return averageValue;
}

static int LargestNumber(int[] nums, int count)
{
    int largestValue = 0;
    // Use the first elements as the largestValue
    largestValue = nums[0];
    // Check if there any elements larger then the current largestValue
    for (int index = 1; index < count; index++)
    {
        if (nums[index] > largestValue)
        {
            largestValue = nums[index];
        }
    }

    return largestValue;
}

static int SmallestNumber(int[] nums, int count)
{
    int smallestValue = 0;
    // Use the first elements as the smallestValue
    smallestValue = nums[0];
    // Check if there any elements smaller then the current smallestValue
    for (int index = 1; index < count; index++)
    {
        if (nums[index] < smallestValue)
        {
            smallestValue = nums[index];
        }
    }
    return smallestValue;
}

static int Mode(int[] nums, int count)
{
    int modeValue = 0;
    // Sort the array in sequnce to we can check the remaining numbers
    Array.Sort(nums);
    // Process each element in the array
    for (int outerIndex = 0; outerIndex < count; outerIndex++)
    {
        for (int innerIndex = outerIndex + 1; innerIndex < count; innerIndex++)
        {
            if (nums[outerIndex] == nums[innerIndex])
            {
                // TODO
            }
        }
    }

    return modeValue;
}
