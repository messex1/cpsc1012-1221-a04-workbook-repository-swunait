// Print the literal message shown below to the Console screen:
// My name is Don Iveson, my age is 45 and I hope to earn $204,747.00 per year

// Console.WriteLine("My name is Don Iveson, my age is 45 and I hope to earn $204,747.00 per year");

// Declare variables for the name, age, and salary
string name;
int age;
double annualPay;

// Assign sample values for the name, age, and annualPay
//name = "Shampoo Voo";
//age = 65;
//annualPay = 123456.78;

// Prompt for the name, age, and annualPay
Console.Write("Enter your name: ");
name = Console.ReadLine();
Console.Write("Enter your age: ");
age = int.Parse(Console.ReadLine());
Console.Write("Enter your expected annual salary: ");
annualPay = double.Parse(Console.ReadLine());

// Write a message with the name, age, and salary
Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");
