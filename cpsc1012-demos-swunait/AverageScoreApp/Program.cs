// Finds the average of up to 100 scores.
const int MAX_NUM_SCORES = 100; // Max number of scores
int count; // Actual number of scores
double[] score = new double[MAX_NUM_SCORES]; // Array of size
double sum = 0; // Sum of array elements
string userInput; // To hold user keyboard input value
                  // Prompt the user for the number of scores.
Console.WriteLine("Enter the number of scores: ");
userInput = Console.ReadLine();
count = int.Parse(userInput);
// Read in the scores and store them in the array.
Console.WriteLine("Enter the scores: ");
for (int index = 0; index < count; index++)
{
    userInput = Console.ReadLine();
    score[index] = double.Parse(userInput);
}
Console.WriteLine();
// Find and display the average of the scores
for (int index = 0; index < count; index++)
{
    sum += score[index]; // Sum the scores
}
Console.WriteLine($"The average is {sum / count}");
