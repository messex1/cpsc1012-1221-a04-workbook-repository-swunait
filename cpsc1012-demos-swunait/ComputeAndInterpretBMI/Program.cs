// Prompt the user to enter the weight in pounds
Console.Write("Enter weight in pounds: ");
double weight = double.Parse(Console.ReadLine());

// Prompt the user to enter the height in inches
Console.Write("Enter height in inches: ");
double height = double.Parse(Console.ReadLine());

const double kilogramPerPound = 0.45359537;
const double metersPerInch = 0.0254;

// Compute BMI
double weightInKilograms = weight * kilogramPerPound;
double heightInMeters = height * metersPerInch;
double bmi = weightInKilograms / (heightInMeters * heightInMeters);


// Display the BMI Classification
Console.WriteLine($"Your BMI is {bmi}");
Console.Write("Your BMI classification is");
//if (bmi < 18.5)
//{
//    Console.WriteLine("Underweight");
//}
//else if (bmi < 25)
//{
//    Console.WriteLine("Normal");
//}
//else if (bmi < 30)
//{
//    Console.WriteLine("Overweight");
//}
//else
//{
//    Console.WriteLine("Obese");
//}
if (bmi < 18.5)
{
    Console.WriteLine("Underweight");
}
else if (bmi >= 18.5 && bmi < 25)
{
    Console.WriteLine("Normal");
}
else if (bmi >= 25 && bmi < 30)
{
    Console.WriteLine("Overweight");
}
else
{
    Console.WriteLine("Obese");
}

