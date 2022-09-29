/* Purpose: To track the number of students that pass or fail 
 *          an examination for 10 students
 *          
 * Inputs:  result (1=pass, 2=fail)
 * 
 * Outputs: pass count
 *          fail count
 *          
 * Algorithm:   1) Set studentCount = 1
 *                 Set passCount = 0
 *                 Set failCount = 0
 *              2) While studentCount <= 10 then do the following
 *                  1) Prompt for result
 *                  2) If result = 1 then 
 *                          increment passCount
 *                     else if result = 2 then
 *                          increment failCount
 *                  3) Increment studentCount
 *              3) Output the passCount and failCount
 * 
 * */
const int MaxStudents = 10;
int studentCount = 1;
int passCount = 0;
int failCount = 0;
int result = 0;


while (studentCount <= MaxStudents)
{
    bool validInput = false;

    do
    {
        Console.Write("Enter result (1=pass, 2=fail): ");
        try
        {
            result = int.Parse(Console.ReadLine());
            if (result != 1 && result != 2)
            {
                Console.WriteLine("Invalid input value. Try again");
            }
            else
            {
                validInput = true;
            }
        } 
        catch//(Exception ex)
        {
            Console.WriteLine("Invalid input value. Please enter a integer number");
            //Console.WriteLine(ex.Message);
            //Console.WriteLine($"An exception has occured with message: {ex.Message}");
        }
       
    } while (!validInput);//while (validInput == false);

    if (result == 1)
    {
        passCount++;
    }
    else
    {
        failCount++;
    }
    studentCount++;
    
}
Console.WriteLine($"Passed: {passCount}");
Console.WriteLine($"Failed: {failCount}");