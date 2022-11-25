using UnderstandingObjectsWorksheet;

int quizTotal;
int quizWeight;
string studentName;
int studentMark;

List<Quiz> quizzes = new List<Quiz>();
char addAnotherEntry = 'n';

Console.Write("Enter quiz total: ");
quizTotal = int.Parse(Console.ReadLine());
Console.Write("Enter quiz weight: ");
quizWeight = int.Parse(Console.ReadLine());

do
{
    Console.Write("Enter student name: ");
    studentName = Console.ReadLine();
    Console.Write("Enter student mark: ");
    studentMark = int.Parse(Console.ReadLine());
    // Create a new Quiz object
    Quiz currentQuiz = new Quiz(studentMark, quizTotal, quizWeight, studentName);
    // Add the Quiz object to the list of quizzes
    quizzes.Add(currentQuiz);
    // Check if user wants to add another entry
    Console.Write("Add another entry (Y|N): ");
    addAnotherEntry = char.Parse(Console.ReadLine());
    addAnotherEntry = char.ToLower(addAnotherEntry);
} while (addAnotherEntry == 'y');

Console.WriteLine($"{"Total",-15} {"Weight",-5}");
Console.WriteLine($"{quizTotal,-15} {quizWeight,-5}");

Console.WriteLine($"{"Name",-15} {"Mark",-5} {"Percentage",-10}");
int markSum = 0;
foreach(Quiz currentQuiz in quizzes)
{
    Console.WriteLine($"{currentQuiz.StudentName,-15} {currentQuiz.Mark,-5} {currentQuiz.GetPercentage():F2}%");
    markSum += currentQuiz.Mark;
}
double averageMark = markSum / quizzes.Count;
Console.WriteLine($"Average mark: {averageMark:F2}%");

