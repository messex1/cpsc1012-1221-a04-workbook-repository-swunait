double side;
double height;
double volume;
double surfaceArea;

side = GetSafeDouble("Enter the base side of the pyramid: ");
height = GetSafeDouble("Enter the height of the pyramid: ");
volume = CalculateVolume(side, height);
surfaceArea = CalculateSurfaceArea(side, height);
Console.Write($"Volume = {volume:F4}");
Console.WriteLine($"Surface area = {surfaceArea:F4}");


//side = 5;
//height = 6;
//volume = CalculateVolume(side, height);
//surfaceArea = CalculateSurfaceArea(side, height);
//Console.WriteLine($"Expected volume 50.0000, Actual volume {volume:F4}");
//Console.WriteLine($"Expected surface area 90.0000, Actual surface area {surfaceArea:F4}");

//side = 6;
//height = 5;
//volume = CalculateVolume(side, height);
//surfaceArea = CalculateSurfaceArea(side, height);
//Console.WriteLine($"Expected volume 60.0000, Actual volume {volume:F4}");
//Console.WriteLine($"Expected surface area 105.9714, Actual surface area {surfaceArea:F4}");

//side = 5;
//height = 5;
//volume = CalculateVolume(side, height);
//surfaceArea = CalculateSurfaceArea(side, height);
//Console.WriteLine($"Expected volume 41.6667, Actual volume {volume:F4}");
//Console.WriteLine($"Expected surface area 80.9017, Actual surface area {surfaceArea:F4}");

//side = 6;
//height = 6;
//volume = CalculateVolume(side, height);
//surfaceArea = CalculateSurfaceArea(side, height);
//Console.WriteLine($"Expected volume 72.0000, Actual volume {volume:F4}");
//Console.WriteLine($"Expected surface area 116.4984, Actual surface area {surfaceArea:F4}");

static double GetSafeDouble(string promptMessage)
{
    double doubleValue = 0;
    bool validInput = false;

    while (! validInput)
    {
        Console.Write(promptMessage);
        try
        {
            doubleValue = double.Parse(Console.ReadLine());
            if (doubleValue > 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("ERROR: Invalid number...try again");
            }
        }
        catch(Exception)
        {
            Console.WriteLine("ERROR: Invalid number...try again");
        }
    }

    return doubleValue;
}

static double SideSquared(double side)
{
    return side * side;
}

static double CalculateVolume(double side, double height)
{
    double volume = 0;
    volume = (1.0/3) * SideSquared(side) * height;
    volume = Math.Round(volume, 4);
    return volume;
}

static double CalculateSurfaceArea(double side, double height)
{
    double surfaceArea = 0;
    surfaceArea = SideSquared(side)
        + 2 * side * Math.Sqrt(SideSquared(side) / 4 + SideSquared(height));
    return surfaceArea;
}