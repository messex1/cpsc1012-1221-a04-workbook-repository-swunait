double amount = 0;
double annualInterestRate = 0;
int years = 0;
const char QuitProgramChoice = 'q';
char menuChoice = QuitProgramChoice;

do
{
    DisplayMenu();
    menuChoice = char.Parse(Console.ReadLine());
    
    switch (menuChoice)
    {
        case 'a': // enter investment amount
            Console.Write("Enter investment amount: ");
            amount = double.Parse(Console.ReadLine());
            break;
        case 'i': // enter interest rate
            Console.Write("Enter annual interest rate in percentage:");
            annualInterestRate = double.Parse(Console.ReadLine());
            break;
        case 'y': // enter years
            Console.Write("Enter number of years: ");
            years = int.Parse(Console.ReadLine());
            break;
        case 'f': // print future values
            PrintFutureValues(amount, annualInterestRate, years);
            break;
        case 'q':
            break;// quit program
        default:    // invalid menu choice
            Console.WriteLine($"Invalid menu choice {menuChoice}. Try again.");
            break;
    }

} while (menuChoice != QuitProgramChoice);
Console.WriteLine("If you like this program, please consider a donation of $1 to my PayPal account.");

static void DisplayMenu()
{
    const string MenuOptions = @"Investment Program
a) Enter investment amount
i) Enter annual interest rate
y) Enter number of years
f) Show future value
q) Quit program
Your choice >>> ";
    Console.Write(MenuOptions);
}


static void PrintFutureValues(double amount, double apr, int years)
{
    Console.WriteLine($"Annual Interest Rate: {apr}");
    Console.WriteLine($"Investment Amount: {amount}");
    Console.WriteLine($"{"Year",4} {"Future Value",15}");
    for (int currentYear = 1; currentYear <= years; currentYear++)
    {
        double futureValue = FutureInvestmentValue(amount, apr, currentYear);
        Console.WriteLine($"{currentYear, 4} {futureValue, 15:C}");
    }
}

static double FutureInvestmentValue
(
    double investmentAmount,
    double annualInterestRate,
    int numberOfYears
)
{
    double futureValue = 0;
    double monthlyInterestRate = ConvertToMonthlyInterestRate(annualInterestRate);
    futureValue = investmentAmount * Math.Pow(1 + monthlyInterestRate, numberOfYears * 12);
    return futureValue;
}

static double ConvertToMonthlyInterestRate(double annualInterestRate)
{
    return annualInterestRate / 12 / 100;
}
