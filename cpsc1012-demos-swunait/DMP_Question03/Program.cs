/*  Purpose:    Determines the letter grade of a student mark
 *  
 *  Inputs:     name
 *              mark between 0 and 100
 * 
 *  Outputs:    The name and grade letter of the student
 *  
 *  Algorithm:  0) Display a welcome message
 *              1) Prompt and read in the student name and mark
 *              2) Assign a grade letter using the table below
 *              
 *              Condition                   Action
 *              ---------                   -------
 *              mark >= 90 and <= 100       gradeLetter = A
 *              mark >= 80 and <= 89        gradeLetter = B
 *              mark >= 70 and <= 79        gradeLetter = C
 *              mark >= 50 and <= 69        gradeLetter = D
 *              mark >= 0 and <= 49         gradeLetter = F
 *              
 *              3) Display the name and grade letter of the student
 *              
 * Test Plan:   Test Case           Test Data           Expected Results
 *              ---------           ---------           ----------------
 *              A grade             mark = 90           gradeLetter = A
 *              B grade             mark = 89           gradeLetter = B
 *              C grade             mark = 75           gradeLetter = C
 *              D grade             mark = 69           gradeLetter = D
 *              F grade             mark = 49           gradeLetter = F
 *              out of range        mark = 101          error message
 *              out of range        mark = -10          error message
 * 
 * */
// Display a welcome message
Console.WriteLine("This program determines the grade letter for mark.");
// Prompt and read in the student name and mark.
Console.Write("Enter the student name: ");
string name = Console.ReadLine();
Console.Write("Enter the student mark percentage (0-100):");
int mark = int.Parse(Console.ReadLine());

// Determine if mark is out of range
// True - Display an error message
// False - Diplay the student name and mark
//if (gradeLetter == 'U')
if (mark < 0 || mark > 100)
{
    Console.WriteLine($"Error! The mark {mark} must be between 0 and 100.");
}
else
{
    // Determine the grade letter for the student using their mark
    char gradeLetter;
    if (mark >= 90 && mark <= 100)
    {
        gradeLetter = 'A';
    }
    else if (mark >= 80 && mark <= 89)
    {
        gradeLetter = 'B';
    }
    else if (mark >= 70 && mark <= 79)
    {
        gradeLetter = 'C';
    }
    else if (mark >= 50 && mark <= 69)
    {
        gradeLetter = 'D';
    }
    else
    {
        gradeLetter = 'F';
    }
    // Display the student name and grade letter
    Console.WriteLine($"{name} grade is {gradeLetter}");
}

        