/* Purpose: To calculate the average of a series of input marks between 0 and 100.
 * 
 * Input:   mark (between 0-100, outside of range to quit)
 * 
 * Output:  averageMark
 * 
 * Algorithm:   averageMark = sumOfMarks / markCount
 * 
 *              1) Prompt for mark
 *              2) While mark >= 0 and mark <= 100 do the following:
 *                      a.  Calculate
 *                          sumOfMarks = sumOfMarks + mark
 *                          markCount = markCount + 1
 *                      b.  Prompt for another mark   
 *                 End While
 *              3) Calculate averageMark
 *                      averageMark = sumOfMarks / markCount
 *              4) Print the averageMark        
 * */
double sumOfMarks = 0;
int markCount = 0;
double mark;
Console.WriteLine("This program calculates the average of a series of marks");
// Prompt for mark
//Console.Write("Enter a mark between 0 and 100 (outside of range to quit): ");
//mark = double.Parse(Console.ReadLine());

//while (mark >= 0 && mark <= 100)
//{
//    sumOfMarks = sumOfMarks + mark;
//    markCount += 1;

//    Console.Write($"Enter a mark between 0 and 100 (outside of range to quit): ");
//    mark = double.Parse(Console.ReadLine());
//}

do
{
    Console.Write($"Enter a mark between 0 and 100 (outside of range to quit): ");
    mark = double.Parse(Console.ReadLine());
    if (mark >= 0 && mark <= 100)
    {
        sumOfMarks = sumOfMarks + mark;
        markCount += 1;
    }
} while (mark >= 0 && mark <= 100);

if (markCount > 0)
{
    // Calculate the averageMark
    double averageMark = sumOfMarks / markCount;
    // Print the averageMark
    Console.WriteLine($"The average mark is {averageMark}");
}
else
{
    Console.WriteLine("No valid marks were entered");
}
