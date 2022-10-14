/*  Purpose:    Determine the price of admission to a threatre based on the age
 *  
 *  Inputs:     Age
 * 
 *  Outputs:    Admission Price
 *  
 *  Algorithm:  1) Prompt and read in the customer age
 *              2) Determine and print the admission price based on the customer age
 *              
 *              Test Condition          Action
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

Console.WriteLine("This program determines the admission price based on a customer age.");

// Prompt and read in the customer age
//Console.Write("Enter the age of the customer: ");
//int age = int.Parse(Console.ReadLine());
int age = PromptForIntegerValue("Enter the age of the customer: ");

// Declare a variable to store the admission price
double price = GetTicketPrice(age);

Console.WriteLine($"The admission price for a {age} years old is {price:C}");

static int PromptForIntegerValue(string promptMessage)
{
    int integerValue = 0;

    Console.Write(promptMessage);
    while ( ! int.TryParse(Console.ReadLine(), out integerValue))
    {
        Console.WriteLine("Invalid input value. Please enter an integer value.");
        Console.Write(promptMessage);
    }
    return integerValue;
}

static int PromptForIntegerRange(string promptMessage, int minValue, int maxValue)
{
    int integerValue = 0;

    integerValue = PromptForIntegerValue(promptMessage);
    while (integerValue < minValue || integerValue > maxValue)
    {
       Console.WriteLine($"Invalid input value. Must between {minValue} and {maxValue} inclusively");
        integerValue = PromptForIntegerValue(promptMessage);
    }
    return integerValue;
}



static double GetTicketPrice (int age)
{
    double ticketPrice = 0.00;

    if (age <= 6)
    {
        ticketPrice = 0.00;
    }
    else if (age <= 17)
    {
        ticketPrice = 9.80;
    }
    else if (age <= 54)
    {
        ticketPrice = 11.30;
    }
    else
    {
        ticketPrice = 10.00;
    }

    return ticketPrice;
}