namespace NonTopLevelStatementProgram
{
    internal class Program
    {
        static int luckyNumber;

        static void Main(string[] args)
        {
            GenerateLuckyNumber();
            PrintLuckyNumber();
        }

        static void GenerateLuckyNumber()
        {
            Random rand = new Random();
            luckyNumber = rand.Next(1, 51);
        }

        static void PrintLuckyNumber()
        {
            Console.WriteLine($"{luckyNumber}");
        }
    }
}