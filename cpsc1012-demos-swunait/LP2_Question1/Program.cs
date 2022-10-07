/*  Purpose:    Print a calendar of the days of the month.
 *  
 *  Inputs:     number of days in month (days)
 *              day of the week for first day of month (firstDayOfWeek)
 * 
 *  Outputs:    A calendar of the day of week from Sun to Sat.
 *  
 *  Algorithm:  0) Display a welcome message
 *              1) Prompt and read in days and firstDayOfWeek
 *                  DayOfWeek                     
 *                  0 - Sun
 *                  1 - Mon
 *                  2 - Tue
 *                  3 - Wed
 *                  4 - Thu
 *                  5 - Fri
 *                  6 - Sat      
 *              2) Print column headings from Sun to Sat.
 *              3) Set currentDayOfWeek to 0 (Sun)
 *                  Set startPrintingDay to false
 *              4)  For day ranging from 1 through days do the following:
 *                      a. If currentDayOfWeek = firstDayOfWeek Then
 *                              startPrintDay = true
 *                         End If
 *                         
 *                         If startPrintDay = true Then
 *                              Print day
 *                              Increment Day
 *                              
 *                              If currentDayOfWeek = Sat (6) Then
 *                                  Print Newline
 *                              End If   
 *                         
 *                         Else
 *                              Print "   "
 *                         End If
 *                              Increment currentDayOfWeek
 *                              If currentOfDayOfWeek > Sat (6) Then
 *                                  currentDayOfWeek = Sun (0)
                                End If                          
 *                  End For
 * 
 * 
 * */


// Display a welcome message
Console.WriteLine("This program prints a monthly calendar.");

int days,
    firstDayOfWeek;
int currentDayOfWeek;
bool startPrintingDay;
// Prompt and read in days and firstDayOfWeek
Console.Write("Enter number of days in month: ");
days = int.Parse(Console.ReadLine());
Console.Write("Enter 1st day of week (0-Sun, 1-Mon, 2-Tue, 3-Wed, 4-Thu, 5-Fri, 6-Sat): ");
firstDayOfWeek = int.Parse(Console.ReadLine());

//Print column headings from Sun to Sat.
Console.WriteLine("Sun  Mon  Tue  Wed  Thu  Fri  Sat");
// Set currentDayOfWeek to 0(Sun) and  startPrintingDay to false
currentDayOfWeek = 0;
startPrintingDay = false;

// For day ranging from 1 through days do the following:
for (int day = 1; day <= days;)
{
    // If currentDayOfWeek = firstDayOfWeek Then
    if (currentDayOfWeek == firstDayOfWeek)
    {
        startPrintingDay = true;
    }

    if (startPrintingDay)
    {
        //  Print day
        Console.Write($"{day,-5}");
        // Increment Day
        day++;
        // If currentDayOfWeek = Sat (6) Then
        if (currentDayOfWeek == 6)
        {
            Console.WriteLine();
        }

        // If currentOfDayOfWeek > Sat (6) Then
        if (currentDayOfWeek > 6)
        {
            currentDayOfWeek = 0;
        }
    }
    else
    {
        Console.Write("     ");
    }

    // Increment currentDayOfWeek
    currentDayOfWeek++;

}
