/* Purpose: Determine if a year is a leap year
 * 
 * Inputs:  year
 * 
 * Outputs: A message indicating if year is a leap year
 * 
 * Algorithm:   1) Prompt and read in a year
 *              2) Determine if year is a leap year:
 *                  1) divisible by 4 BUT not by 100
 *                      (year % 4 == 0) && (year % 100 != 0)
 *                      (year % 4 == 0) && !(year % 100 == 0)
 *                  2) divisible by 400
 *                      (year % 400 == 0)
 *              3) Display a message indicating year is a leap year or not
 * 
 * */
// Delcare variables for inputs (year) and outputs
int year;
// Prompt and read a year
Console.WriteLine("This program determines if a year is a leap year.");
Console.Write("Enter a year: ");
year = int.Parse(Console.ReadLine());
// Determine if year is a leap year
//if ((year % 4 == 0) && !(year % 100 == 0))
//{
//    Console.WriteLine($"{year} is a leap year");
//}
//else if (year % 400 == 0)
//{
//    Console.WriteLine($"{year} is a leap year");
//}
//else
//{
//    Console.WriteLine($"{year} is NOT a leap year");
//}
if ( ((year % 4 == 0) && !(year % 100 == 0)) || (year % 400 == 0))
{
    Console.WriteLine($"{year} is a leap year");
}
else
{
    Console.WriteLine($"{year} is NOT a leap year");
}