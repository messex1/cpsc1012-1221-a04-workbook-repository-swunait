int numTrips; // Actual number of trips
double[] miles = new double[MAX_TRIPS]; // Miles data
double[] kms = new double[MAX_TRIPS]; // Kilometers data
string userInput; // To hold user keyboard input value
                  // Prompt the user for the number of trips.
Console.WriteLine("Enter the number of trips: ");
userInput = Console.ReadLine();
numTrips = int.Parse(userInput);
// Read the mileage for each trip.
ReadMiles(miles, numTrips);
// Convert from miles to kilometers.
MilesToKms(miles, kms, numTrips);
// Display the data for each trip.
DisplayData(miles, kms, numTrips);

// --------------------------------------------------------------------
static void ReadMiles(double[] tripMiles, int count)
{
    string userInput; // To hold user input value
    Console.WriteLine("Enter the mileage for each trip: ");
    for (int index = 0; index < count; index++)
    {
        userInput = Console.ReadLine();
        // Store the userInput in the tripMiles array
        tripMiles[index] = double.Parse(userInput);
    }
}
static void MilesToKms(double[] tripMiles, double[] tripKms, int count)
{
    for (int index = 0; index < count; index++)
    {
        tripKms[index] = tripMiles[index] * MILES_TO_KMS;
    }
}
static void DisplayData(double[] tripMiles, double[] tripKms, int count)
{
    Console.WriteLine($"{"Trip",4} {"Miles",7} {"Kilometers",12}");
    for (int index = 0; index < count; index++)
    {
        Console.WriteLine($"{index + 1,4} {tripMiles[index],7} {tripKms[index],12}"
        );
    }
}

public partial class Program
{
    const int MAX_TRIPS = 100; // Max number of trips
    const double MILES_TO_KMS = 1.61; // Miles to kilometers conversion factor

}