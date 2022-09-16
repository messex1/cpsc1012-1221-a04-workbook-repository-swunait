const int MinNumber = 1;
const int MaxNumber = 9;
Random keygen = new Random();
// Generate two random numbers between 1 and 9
int number1 = keygen.Next(MinNumber, MaxNumber + 1);
int number2 = keygen.Next(MinNumber, MaxNumber + 1);
// Show question
Console.Write($"What is {number1} + {number2} = ? ");
// Receive answer
String inputValue = Console.ReadLine();
int answer = int.Parse(inputValue);
// Display result
//Console.WriteLine($"{number1} + {number2} = {answer} is {(number1 + number2)== answer}");
// Caclulate the correct answer
int correctAnswer = number1 + number2;
// Determine if the answer is correct or not
if (answer == correctAnswer)
{
    Console.WriteLine("Correct answer.");
}
else
{
    Console.WriteLine($"Incorrect answer. The correct answer is {correctAnswer}");
}