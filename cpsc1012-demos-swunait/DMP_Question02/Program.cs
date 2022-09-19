/*  Purpose:    Determine the price of admission to a threatre based on the age
 *  
 *  Inputs:     Age
 * 
 *  Outputs:    Admission Price
 *  
 *  Algorithm:  1) Prompt and read in the customer age
 *              2) Determine and print the admission price based on the customer age
 *              
 *              Test Condition          Price
 *              --------------          ------
 *              age <= 6                $0.00
 *              age >= 7 and <= 17      $9.80
 *              age >= 18 and <= 54     $11.35
 *              age >= 55               $10.00
 * 
 * Test Plan:   Test Case           Test Data           Expected Results
 *              ---------           ---------           ----------------             
 *              children            6                   Price = $0.00
 *              student             10                  Price = $9.80
 *              adult               20                  Price = $11.35
 *              senior              55                  Price = $10.00
 *                            
 * */
// Display a welcome message
using System.Diagnostics;

Console.WriteLine("This program determines the admission price based on a customer age.");
// Prompt and read in the customer age
Console.Write("Enter the age of the customer: ");
int age = int.Parse(Console.ReadLine());

// Declare a variable to store the admission price
double price;
// Determine an print the admission price using the customer age
if (age <= 6)
{
    //Console.WriteLine($"The admission price for a {age} years old is $0.00");
    price = 0.00;
}
else if (age >= 7 && age <= 17)
{
    //Console.WriteLine($"The admission price for a {age} years old is $9.80");
    price = 9.80;
}
else if (age >= 18 && age <= 54)
{
    //Console.WriteLine($"The admission price for a {age} years old is $11.30");
    price = 11.30;
}
else
{
    //Console.WriteLine($"The admission price for a {age} years old is $10.00");
    price = 10.00;
}

Console.WriteLine($"The admission price for a {age} years old is {price:C}");