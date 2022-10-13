Console.WriteLine("This program computes the average for a series of marks from a text file.");

int sum = 0;
int countMarks = 0;
const string DataFilePath = @"..\..\..\marks.txt";

try
{
    using (StreamReader reader = new StreamReader(DataFilePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            int currentMark = int.Parse(line);
            sum += currentMark;
            countMarks++;
        }
        // Compute the avearge
        double average = sum / countMarks;
        Console.WriteLine($"Average of the {countMarks} marks is {average:F1}");

    }
} 
catch (Exception ex)
{
    Console.WriteLine($"Error reading from {DataFilePath} with exception {ex.Message}");
}
