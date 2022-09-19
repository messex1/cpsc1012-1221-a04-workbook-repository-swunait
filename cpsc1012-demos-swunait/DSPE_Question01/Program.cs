/* Purpose: Simulate flipping a coin and letting the user guess the face value of the the coin toss.
 * 
 * Inputs:  guess (0 for head, 1 for tail)
 * 
 * Outputs: A message indicating if the guess is correct or incorrect
 * 
 * Algorithm:   1) Prompt and read in guess (0 for head, 1 for tail)
 *              2) Flip the coin (generate a number between 0 and 1)
 *              3) Determine if coinTossFaceValue matches guessFaceValue
 * 
 * */
// Declare variables for inputs (guessFaceValue) and outputs (coinTossFaceValue)
int guessFaceValue;
int coinTossFaceValue;
string guessFaceName;

// Flip the coin 
Random rand = new Random();
coinTossFaceValue = rand.Next(0, 2); // generate a number between 0 and 1
Console.WriteLine($"The random number is {coinTossFaceValue}");

// Prompt and read in guess (0 for head, 1 for tail)
Console.WriteLine("This is coin toss simulation program.");
Console.WriteLine("Enter your guess (0 for head, 1 for tail): ");
guessFaceValue = int.Parse(Console.ReadLine());

if (guessFaceValue == 0)
{
    guessFaceName = "head";
}
else
{
    guessFaceName = "tail";
}

//  Determine if coinTossFaceValue matches guessFaceValue
if (guessFaceValue == coinTossFaceValue)
{
    Console.WriteLine($"{guessFaceName} is correct!");
}
else
{
    Console.WriteLine($"{guessFaceName} is incorrect!");
}
