/*  Purpose:    Determine if a number is positive or negative or zero
 * 
 *  Inputs:     integer number
 *  
 *  Output:     A message identifying if the number is positive, negative, or zero
 * 
 *  Algorithm:  1) Prompt and read in a number
 *              2) Determine and output if the number is positive, negative, or zero
 *              
 *                  Test Condition          Action          
 *                  --------------          -----------
 *                  number > 0              Output positive
 *                  number < 0              Output negative
 *                  number == 0             Output zero
 * Test Plan:   Test Case           Test Data           Expected Results
 *              ---------           ---------           ----------------             
 *              positive number     number = 10         10 is positive
 *              negative number     number = -10        -10 is negative
 *              zero                number = 0          0 is zero
 * */
// Display a welcome message
Console.WriteLine("This program determines if a number is positive or negative or zero.");
// Prompt and read in a number
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

// Determine and output if the number is positive, negative, or zero
//if (number > 0)
//{
//    Console.WriteLine($"{number} is positive");
//}
//if (number < 0)
//{
//    Console.WriteLine($"{number} is negative");
//}
//if (number == 0)
//{
//    Console.WriteLine($"{number} is zero");
//}
if (number > 0)
{
    Console.WriteLine($"{number} is positive");
}
else if (number < 0)
{
    Console.WriteLine($"{number} is negative");
}
else
{
    Console.WriteLine($"{number} is zero");
}