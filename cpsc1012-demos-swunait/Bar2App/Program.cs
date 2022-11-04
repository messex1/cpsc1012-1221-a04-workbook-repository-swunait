/* Purpose:     A program that displays a bar graph from a set of integer values entered by the 
user. 
 * 
 * Inputs:      The number of bars (up to 10)
 * 
 * Outputs:     A list of integer values in the range 0 to 50
 * 
 * Algorithm:   1) Prompt for number of bars
 *              2) Prompt for value for each bar
 *                  For 0..bars do the following
 *                      1) Prompt for value for each bar and store it in array
 *                  End For
 *              3) Print the first (0) and last (50) column number  
 *                  For 0..50 do the following
 *                      If index = 0 or 50 then 
 *                          Print index
 *                      Else
 *                          Print " "
 *                      End If
 *                  End For
 *              4) Print the first (0) and last (50) column number  
 *                  For 0..50 do the following
 *                      If index % 10 = 0 then 
 *                          Print "|"
 *                      Else
 *                          Print "-"
 *                      End If
 *                  End For
 *              5) For 0..< barCount do the following:
 *                      Print "|"  
 *                      For 0..< values[index] do the following
 *                          Print "*"
 *                      End For
 *                 End For
 * 
 * */
int barCount;
double[] values;
Console.WriteLine("This program prints a scaled down bar graph");
Console.Write("Enter the number of bars: ");
barCount = int.Parse(Console.ReadLine());
values = new double[barCount];

ReadData(values, barCount);
int[] scaledValues = new int[barCount];
double maxValue = MaxDataValue(values, barCount);
ScaleValues(values, scaledValues, barCount, maxValue);
DisplayBarGraph(scaledValues, barCount, maxValue);


static void ReadData(double[] data, int numValues)
{
    for (int index = 0; index < numValues; index++)
    {
        Console.Write($"Enter value for bar {index + 1}: ");
        data[index] = double.Parse(Console.ReadLine());
    }

}

static double MaxDataValue(double[] data, int numValues)
{
    double maxValue = 0;
    // Assume first element contains the max value
    maxValue = data[0];
    // Check if the remaining elements if there is another element with a larger value
    for (int index = 1; index < numValues; index++)
    {
        if (data[index] > maxValue)
        {
            // Assign new maxValue using the current element
            maxValue = data[index];
        }
    }

    return maxValue;
}

static void ScaleValues(double[] data, int[] scaledData, int numValues, double maxValue)
{ 
    for (int index = 0; index < numValues; index++)
    {
        scaledData[index] = (int) (data[index] * (50 / maxValue));
    }
} 

static void DisplayBarGraph(int[] scaledData, int numValues, double maxValue)
{
    for (int index = 0; index <= MaxValue; index++)
    {
        if (index == 0 || index == MaxValue)
        {
            if (index == 0)
            {
                Console.Write(0);
            }
            else
            {
                Console.Write(maxValue);
            }
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
    //Console.Write("0");
    //Console.WriteLine($"{MaxValue}".PadLeft(MaxValue + 1));

    for (int index = 0; index <= MaxValue; index++)
    {
        if (index % 10 == 0)
        {
            Console.Write("|");
        }
        else
        {
            Console.Write("-");
        }
    }
    Console.WriteLine();

    for (int currentRow = 1; currentRow <= numValues; currentRow++)
    {
        Console.Write("|");
        for (int index = 0; index < scaledData[currentRow - 1]; index++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

}

public partial class Program
{
    const int MaxValue = 50;

}