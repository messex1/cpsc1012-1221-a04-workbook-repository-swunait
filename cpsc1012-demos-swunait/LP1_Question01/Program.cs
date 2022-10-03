/*
 * Purpose:    Display the sum of the square of a integer value (mySquare)
 *
 * Inputs:     integer value(mySquare)
 *
 * Ouputs:     Print the sum of the square of the integer value mySquare) 
 *
 * Algorithm:   0) Display a welcome message
 *              1) Set sum = 0
 *              2) Prompt and read in mySquare
 *              3)  For number ranging from 1 to mySquare do the following:
 *                      a.Calculate
 *                              sum = sum + number * number
                    * End For
 *              4) Print the sum
 * 
 * */
// Display a welcome message
Console.WriteLine("This program prints the sum of the squares for an integer value");
// Set sum = 0
int sum = 0;
int mySquare;
// Prompt and read in mySquare
Console.Write("Enter the integer value to square: ");
mySquare = int.Parse(Console.ReadLine());
// For number ranging from 1 to mySquare do the following:
for (int number = 1; number <= mySquare; number++)
{
    sum = sum + (number * number);
}
// Print the sum
Console.WriteLine($"The sum of the squares for {mySquare} is {sum}");
