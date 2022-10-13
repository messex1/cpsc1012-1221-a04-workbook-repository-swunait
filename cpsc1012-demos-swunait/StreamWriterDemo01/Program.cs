// Display a welcome message
Console.WriteLine("This program writes a series of user input marks to a file.");

const string DataFilePath = @"..\..\..\marks.txt";
try
{
    using (StreamWriter writer = new StreamWriter(DataFilePath))
    {
        int mark = 0;

        do
        {
            //bool validMark = false;

            //while (!validMark)
            //{
            //    // Prompt for a mark
            //    Console.Write("Enter a mark between 0 and 100: ");
            //    try
            //    {
            //        mark = int.Parse(Console.ReadLine());
            //        validMark = true;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid input value. Please enter an integer number.");
            //    }
            //}
            Console.Write("Enter a mark between 0 and 100: ");
            while ( ! int.TryParse(Console.ReadLine(), out mark))
            {
                Console.WriteLine("Invalid input value. Try again.");
                Console.Write("Enter a mark between 0 and 100: ");
            }


            // Write the mark to the file if it is a valid mark
            if (mark >= 0 && mark <= 100)
            {
                writer.WriteLine(mark);
            }
        } while (mark >= 0 && mark <= 100);
    }
} 
catch(Exception ex)
{
    Console.WriteLine($"Error writing to file {DataFilePath} with exception {ex.Message}");
}
