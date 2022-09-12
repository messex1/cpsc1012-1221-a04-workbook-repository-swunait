/* Purpose: Sum the digits of a integer number
 * 
 * Inputs:  3 digit integer number
 * 
 * Outputs: Sum of the digits
 * 
 * Algorithm:   1) Prompt and read in a integer number between 0 and 1000
 *              2) Extract the right most digit from the number
 *                  digit1 = number % 10
 *              3) Extract the next right most digit from the number
 *                  digit2 = (number / 10) % 10
 *              4) Extract the next right most digit from the number
 *                  digit3 = (number / 10 / 10) % 10
 *              5) Sum the three digits    
 *                  sum = digit1 + digit2 + digit3
 *              6) Display the sum    
 *                  
 * */
// Delcare variables for inputs (number) and outputs (digit1, digit2, digit3, sum)
int number;
int digit1,
    digit2,
    digit3;
int sum;

// Prompt and read in a integer number between 0 and 1000
Console.Write("Enter a number between 0 and 1000 (exclusive): ");
number = int.Parse(Console.ReadLine());
// Extract the right most digit from the number
digit1 = number % 10;
// Extract the next right most digit from the number
digit2 = (number / 10) % 10;
// Extract the next right most digit from the number
digit3 = (number / 10 / 10) % 10;
// Sum the three digits 
sum = digit1 + digit2 + digit3;
// Display the sum
Console.WriteLine($"The sum of the digits is {sum}");
