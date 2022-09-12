/* Purpose: Compute the future investment value 
 * 
 * Inputs:  investment amount in dollar and cents
 *          annual interest rate as a percentage of 100
 *          years
 * 
 * Outputs:  future investment value
 * 
 * Algorithm:   1) Prompt and read in investmentAmount, annualInterestRate, and years
 *              2) Compute the monthlyInterestRate using the formula:
 *                      monthlyInterestRate = annualInterestRate / 12 / 100
 *              3) Compute the futureValue using the formula:
 *                     futureInvestmentValue = 
 *                          investmentAmount * Math.Pow(1 + monthlyInterestRate, years * 12)
 *          
 *              4) Display the future value
 * */
// Declare varaibles for inputs (investmentAmount, annualInterestRate, years)
// and outputs (monthlyInterestRate, futureInvestmentValue)
using Microsoft.VisualBasic;

double investmentAmount,
        annualInterestRate;
int years;

double monthlyInterestRate,
        futureInvestmentValue;

// Prompt and read in investmentAmount, annualInterestRate, and years
Console.Write("Enter investment amount: ");
investmentAmount = double.Parse(Console.ReadLine());
Console.Write("Enter annual interest rate in percentage: ");
annualInterestRate = double.Parse(Console.ReadLine());
Console.Write("Enter number of years: ");
years = int.Parse(Console.ReadLine());

// Compute the monthlyInterestRate using the formula:
monthlyInterestRate = annualInterestRate / 12 / 100;
// Compute the futureValue using the formula:
futureInvestmentValue = investmentAmount * Math.Pow((1 + monthlyInterestRate), years * 12);
// Round the futureValue to 2 decimal places
futureInvestmentValue = Math.Round(futureInvestmentValue, 2);

// Display the future value
Console.WriteLine($"Future value is {futureInvestmentValue:C}");