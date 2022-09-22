// Purpose: Demonstrate how to format output into fixed-width columns
string name1 = "John Smith";
string name2 = "John Snow";
double price1 = 1.23;
double price2 = 12.34;
double price3 = 123.45;
double total = price1 + price2 + price3;

// Display output in 2 fixed-width columns
// Column 1 is 30 characters
// Column 2 is 20 characters
Console.WriteLine($"{"Customer",-30}{name1, -20}");
Console.WriteLine($"{"Employee",-30}{name2, -20}");
Console.WriteLine($"{"Price1", -30}{price1, 20:C}");
Console.WriteLine($"{"Price2", -30}{price2,20:C}");
Console.WriteLine($"{"Price3", -30}{price3,20:C}");
Console.WriteLine($"{"----------", 50}");
Console.WriteLine($"{total, 50:C}");