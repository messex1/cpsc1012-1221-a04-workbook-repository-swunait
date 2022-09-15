/* Purpose: To let a child to know if parent is proud of their mark
 * 
 * Input:   mark between 0 and 100
 * 
 * Output:  The literal "I am proud of your work" if the mark >= 80
 * 
 * Algorithm:   1) Prompt for the mark
 *              2) Decide if the literal message should be displayed
 * */
Console.Write("Child, what was your test score (0-100): today?");
int mark = int.Parse(Console.ReadLine());

if (mark >= 80)
{
    Console.WriteLine("Child, I am proud of your work.");
}
else
{
    Console.WriteLine("Child, you are in BIG trouble.");
}
