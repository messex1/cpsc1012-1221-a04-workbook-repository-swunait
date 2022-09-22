/*  Purpose:    Determine the tax amount due for a given taxable income.
 *  
 *  Inputs:     Taxable Income in dollars
 *  
 *  Outputs:    Tax amount due
 * 
 *  Algorithm:  0) Display a welcome message
 *              1) Prompt and read in the taxable income amount
 *              2) Determine the tax amount due using the following rules:
 *                  Condition                                   Action
 *                  ----------------------------------------    -----------------
 *                  taxableIncome >= 0 and <= 50,000            taxDue = 0 + 0.05 * taxableIncome
 *                  taxableIncome > 50,000 and <= 100,000       taxDue = 2500 + 0.07 * (taxableIncome - 50000)
 *                  taxableIncome > 100,000                     taxDue = 6000 + 0.09 * (taxableIncome - 100000)
 *              3) Display the tax amount due    
 *                  
 *  Test Plan:  Test Case           Test Data               Action
 *              -------------       --------------------    --------
 *              tax bracket 1       taxableIncome=45000     taxDue = $2250
 *              tax bracket 2       taxableIncome=85000     taxDue = $4950
 *              tax bracket 3       taxableIncome=150000    taxDue = $10500
 * 
 * 
 * */
// Display a welcome message
Console.WriteLine("This program determines the tax amount due for a given taxable income.");
// Prompt and read in the taxable income
Console.Write("Enter your taxable income in dollars: ");
int taxableIncome = int.Parse(Console.ReadLine());
// Determine the tax amount due
double taxAmountDue;
if (taxableIncome >= 0 && taxableIncome <= 50000)
{
    taxAmountDue = 0 + 0.05 * taxableIncome;
}
else if (taxableIncome > 50000 && taxableIncome <= 100000)
{
    taxAmountDue = 2500 + 0.07 * (taxableIncome - 50000);
}
else if (taxableIncome > 100000)
{
    taxAmountDue = 6000 + 0.09 * (taxableIncome - 100000);
}
else
{
    taxAmountDue = 0;
}

// Display the tax amount due
Console.WriteLine($"For an income of {taxableIncome:C} the tax amount due is {taxAmountDue:C}");
