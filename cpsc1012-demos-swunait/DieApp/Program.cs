using DieApp;   // You must import the namespace of the custom class that you defined

// Create two Die objects
Die die1 = new Die(6);
Die die2 = new Die(12);
// Display the initial value of the dice
Console.WriteLine("This simulates the rolling of a 6-sided die and a 12-sided die.");
Console.WriteLine("Initial value of the dice:");
Console.WriteLine($"{die1.Value, -10} {die2.Value, -10}");
// Simulate rolling both dice 5 times
Console.WriteLine("Rolling the dice 5 times.");
for (int count = 1; count <= 5; count++)
{
    // Roll both dice
    die1.Roll();
    die2.Roll();
    // Display the current face value for both dice
    Console.WriteLine($"{die1.Value,-10} {die2.Value,-10}");
}