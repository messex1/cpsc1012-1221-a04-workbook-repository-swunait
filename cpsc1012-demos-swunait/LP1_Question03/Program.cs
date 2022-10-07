/* Purpose: Print the digits on a integer number in a column starting the last digit.
 * 
 * Inputs:  n
 * 
 * Outputs: The digits of n starting the from the last digit
 * 
 * Algorithm:   For a base 10 number system when you divide by 10 the remainder is the right most digit
 *              For example, given n = 3456 divide by 10 repeatly until the quotient is zero.
 *              n / 10          Quotient        Remainder 
 *              3456 / 10       345             6
 *              345 / 10        34              5
 *              34 / 10         3               4
 *              3 / 10          0               3
 * 
 * 
 * */
// Print a welcome message
Console.WriteLine("This program prints each each digit of a integer number start from the right most digit.");
// Prompt and read in a integer number n
Console.Write("Enter an integer number: ");
int n = int.Parse(Console.ReadLine());
// Divide quoitent repeatly until the quotient is zero. Set quotient to n initially.
int quotient = n, remainder;
while (quotient != 0)
{
    remainder = quotient % 10;
    Console.WriteLine(remainder);
    quotient = quotient / 10;
}
