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
int[] values;
const int MaxValue = 50;
Console.WriteLine("This program prints a bar graph");
Console.Write("Enter the number of bars: ");
barCount = int.Parse(Console.ReadLine());
values = new int[barCount];
for (int index = 0; index < barCount; index++)
{
    Console.Write($"Enter value for bar {index + 1}: ");
    values[index] = int.Parse(Console.ReadLine());
}

for (int index = 0; index <= MaxValue; index++)
{
    if (index == 0 || index == MaxValue)
    {
        Console.Write(index);
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

for (int currentRow = 1; currentRow <= barCount; currentRow++)
{
    Console.Write("|");
    for (int index = 0; index < values[currentRow - 1]; index++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


