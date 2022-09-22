/*  Purpose:    Determine how much to bill a customer for internet usage
 *              based on their service package
 *              
 *  Inputs:     Package letter (A,B,C)
 *              Hours used for package A and B
 * 
 *  Outputs:     Monthly bill amount
 *  
 *  Algorithm:  0) Display welcome message
 *              1) Prompt and read the package letter
 *              2) For package A and B, prompt and read in the hours used
 *              3) Determine the monthly bill amount
 *              
 *              Condition           Action
 *              ---------------     --------
 *              package == 'A'      if hours > 10 then
 *                                      monthlyBillAmount = 9.95 + (hours - 10) * 2.00
 *                                  else
 *                                      monthlyBillAmount = 9.95 
 *              
 *              package == 'B'      if hours > 20 then
 *                                      monthlyBillAmount = 13.95 + (hours - 20) * 1.00
 *                                  else
 *                                      monthlyBillAmount = 13.95 
 *              
 *              package == 'C'      monthlyBillAmount = 19.95
 *              
 *             4) Display the monthly bill amount 
 * 
 * Test Plan:   Test Case                       Test Data       Expected Results
 *              ---------------------------     ----------      -----------------
 *              Package A under 10 hours        package=A       monthlyBillAmount = 9.95
 *                                              hours=8
 *              Package A over 10 hours         package=A       monthlyBillAmount = 19.95
 *                                              hours=15    
 *              
 *              Package B under 20 hours        package=B       monthlyBillAmount = 13.95       
 *                                              hours=12        
 *              Package B over 20 hours         package=B       monthlyBillAmount = 23.95
 *                                              hours=30
 *              
 *              Package C                       package=C       monthlyBillAmount = 19.95
 * 
 * 
 * */
//Display a welcome message
Console.WriteLine("This program determines the monthly bill amount for an ISP customer");

// Prompt and read in the package letter
Console.WriteLine("Internet Packages");
Console.WriteLine("-----------------");
Console.WriteLine("A - $9.95/month + $2.00/hr over 10 hours");
Console.WriteLine("B - $13.95/month + $1.00/hr over 20 hours");
Console.WriteLine("C - $19.95/month ");
Console.Write("Enter the internet package (A, B, C):");
char packageLetter = char.Parse(Console.ReadLine());
// Convert the packageLetter to uppercase 
packageLetter = char.ToUpper(packageLetter);
// For package A and B prompt and read in hours used
int hours = 0;
if (packageLetter == 'A' || packageLetter == 'B')
{
    Console.Write("Enter the hours used: ");
    hours = int.Parse(Console.ReadLine());
}

// Determine the monthly bill amount
double monthlyBillAmount;
switch (packageLetter)
{
    case 'A':
        {
            const int PackageAMinHours = 10;
            const double PackageAMinAmount = 9.95;
            const double PackageAOverchargeRate = 2.00;
            if (hours > PackageAMinHours)
            {
                monthlyBillAmount = PackageAMinAmount + (hours - PackageAMinHours) * PackageAOverchargeRate;
            }
            else
            {
                monthlyBillAmount = PackageAMinAmount;
            }
        }
        break;

    case 'B':
        if (hours > 20)
        {
            monthlyBillAmount = 13.95 + (hours - 20) * 1.00;
        }
        else
        {
            monthlyBillAmount = 13.95;
        }
        break;

    case 'C':
        monthlyBillAmount = 19.95;
        break;

    default:
        monthlyBillAmount = 0.00;
        Console.WriteLine("Error! Invalid package entered.");
        break;

}

// Display the monthly bill amount
Console.WriteLine($"The monthly bill amount {monthlyBillAmount:C} for package {packageLetter}.");