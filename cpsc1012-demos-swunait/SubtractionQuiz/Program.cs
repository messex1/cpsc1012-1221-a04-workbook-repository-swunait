// 1. Generate two random single-digit integers
const int MinNumber = 1;
const int MaxNumber = 9;
Random keygen = new Random();
// Generate two random numbers between 1 and 9
int number1 = keygen.Next(MinNumber, MaxNumber + 1);
int number2 = keygen.Next(MinNumber, MaxNumber + 1);

// 2. We do not want subtraction with negative results
// so swap number1 with number 2 if number 1 < number 2
if (number1 < number2)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}
// 3.Prompt the student to answer, "What is number1 - number2?"
Console.Write($"What is {number1} - {number2} = ? ");
int answer = int.Parse(Console.ReadLine());

// 4. Check the student's answer and display whether the answer is correct.
int correctAnswer = number1 - number2;
if (correctAnswer == answer)
{
    Console.WriteLine("Your answer is correct.");
}
else
{
    Console.WriteLine("Your answer is incorrect.");
    Console.WriteLine("The correct answer is shown below.");
    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
}
