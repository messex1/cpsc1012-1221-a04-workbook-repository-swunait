// Purpose: Demostrate differnet technique to read and process
//          character inputs
// Technique 1: use char.Parse(Console.ReadLine()) method 
                //  adv: user change correct input value
                //  dis-adv: allows user to enter more than one character
// Technique 2: use Console.ReadKey().KeyChar
                //  adv: allows only one char input 
                //       user does not need to press Enter key
                //  dis-adv: user cannot correct input
                //           does not move keyboard input cursor to newline

char menuChoice;
Console.Write("Enter choice (A,S,M,D) for type of math question: ");

//menuChoice = char.Parse(Console.ReadLine());

menuChoice = Console.ReadKey().KeyChar;
Console.WriteLine();

// Convert the char input to upper/lower case
menuChoice = char.ToUpper(menuChoice);
switch (menuChoice)
{
    case 'A':
    case 'a':
        // Addition Question
        Console.WriteLine("You selected addition question.");
        break;
    case 'S':
        // Subtraction Question
        Console.WriteLine("You selected subtraction question.");
        break;
    case 'M':
        // Multiplication Question
        Console.WriteLine("You selected multiplication question.");
        break;
    case 'D':
        // Division Question
        Console.WriteLine("You selected division question.");
        break;
    default:
        Console.WriteLine($"Invalid choice of {menuChoice}.");
        Console.WriteLine("Setting default operation to Addition");
        break;
}