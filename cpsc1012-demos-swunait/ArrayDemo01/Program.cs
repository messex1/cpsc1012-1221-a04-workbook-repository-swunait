const int MinimumMark = 0;
const int MaximimMark = 100;
int markCount = 15;
const int MaxMarks = 29;
// Generate 15 random marks between 0 and 100
int[] generatedMarksArray = GenerateRandomMarks(MinimumMark, MaximimMark, markCount);
// Display all the generated marks
DisplayAllMarks(generatedMarksArray);
// Display the highest mark
Console.WriteLine($"The highest mark is: {HighestMark(generatedMarksArray, markCount)}");
// Display the lowest mark
Console.WriteLine($"The lowest mark is: {LowestMark(generatedMarksArray, markCount)}");
// Display the average mark
Console.WriteLine($"The average mark is {AverageMark(generatedMarksArray, markCount)}");

const string DataFilePath = @"../../../GeneratedMarks.txt";
// Write all the marks in generatedMarksArray to a text file
WriteMarksToFile(generatedMarksArray, DataFilePath);
// Read all the marks from a text file into a new array
int[] marksArrayFromFile = new int[MaxMarks];
markCount = ReadMarksFromFile(marksArrayFromFile, DataFilePath);
// Display all the marks read
DisplayMarks(marksArrayFromFile, markCount);

static void DisplayMarks(int[] marks, int markCount)
{
    Console.WriteLine("The marks are as follows: ");
    for (int index = 0; index < markCount; index++)
    {
        int currentMark = marks[index];
        Console.WriteLine($"Mark {index + 1}: {currentMark}");
    }
}
static int[] GenerateRandomMarks(int minMark, int maxMark, int markCount)
{
    // Declare and create a new array of int of size markCount
    int[] marks = new int[markCount];
    // Generate a random mark between minMark and maxMark for each element in marks
    Random rand = new Random();
    for(int index = 0; index < markCount; index++)
    {
        marks[index] = rand.Next(minMark, maxMark + 1);
    }

    return marks;
}

static void DisplayAllMarks(int[] marks)
{
    Console.WriteLine("The marks are as follows: ");

    for (int index = 0; index < marks.Length; index++)
    {
        int currentMark = marks[index];
        Console.WriteLine($"Mark {index + 1}: {currentMark}");
    }

    //int currentMarkNumber = 1;
    //foreach (int currentMark in marks)
    //{
    //    Console.WriteLine($"Mark {currentMarkNumber}: {currentMark}");
    //    currentMarkNumber++;
    //}

}

static int HighestMark(int[] marks, int markCount)
{
    int highestValue = marks[0];
    for (int index = 0; index < markCount; index++)
    {
        if (marks[index] > highestValue)
        {
            highestValue = marks[index];
        }
    }

    return highestValue;
}
static int LowestMark(int[] marks, int markCount)
{
    int lowestValue = marks[0];
    for (int index = 0; index < markCount; index++)
    {
        if (marks[index] < lowestValue)
        {
            lowestValue = marks[index];
        }
    }

    return lowestValue;
}
static double AverageMark(int[] marks, int markCount)
{
    double averageValue = 0;
    double sum = 0.00;
    for (int index = 0; index < markCount; index++)
    {
        //sum = sum + marks[index];
        sum += marks[index];
    }
    averageValue = sum / markCount;

    return averageValue;
}

static void WriteMarksToFile(int[] marks, string dataFilePath)
{
    using(StreamWriter writer = new StreamWriter(dataFilePath))
    {
        foreach(int currentMark in marks)
        {
            writer.WriteLine(currentMark);
        }
    }
}
static int ReadMarksFromFile(int[] marks, string dataFilePath)
{
    int marksRead = 0;
    using (StreamReader reader = new StreamReader(dataFilePath))
    {
        string currentLine;
        int index = 0;
        while ( (currentLine = reader.ReadLine()) != null && (index < marks.Length))
        {
            // Assign the currentLine to the current element in the arrary
            marks[index] = int.Parse(currentLine);
            index++;
        }
        marksRead = index;
    }

    return marksRead;
}
