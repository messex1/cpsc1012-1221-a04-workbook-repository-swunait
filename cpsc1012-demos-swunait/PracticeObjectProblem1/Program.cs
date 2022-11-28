using PracticeObjectProblem1;

string title;
string artist;
int tracks;
double price;

try
{
    Console.Write("Enter the CD title: ");
    title = Console.ReadLine();
    Console.Write("Enter the CD Artist: ");
    artist = Console.ReadLine();
    Console.Write("Enter the CD number of tracks: ");
    tracks = int.Parse(Console.ReadLine());
    Console.Write("Enter the CD price: ");
    price = double.Parse(Console.ReadLine());

    CD cd1 = new CD(title, artist, tracks, price);

    Console.Write("Enter the CD title: ");
    title = Console.ReadLine();
    Console.Write("Enter the CD Artist: ");
    artist = Console.ReadLine();
    Console.Write("Enter the CD number of tracks: ");
    tracks = int.Parse(Console.ReadLine());
    Console.Write("Enter the CD price: ");
    price = double.Parse(Console.ReadLine());

    CD cd2 = new CD(title, artist, tracks, price);

    Console.WriteLine(cd1.CDInfo());
    Console.WriteLine(cd2.CDInfo());
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
