/* Purpose: Print a rectangle shape on the screen with a specific length (columns)
 *          and width (rows)
 * 
 * */

int columns = 25;
int rows = 10;
char rectangleSymbol = '*';

for (int currentRow = 1; currentRow <= rows; currentRow++)
{
    for (int currentColumn = 1; currentColumn <= columns; currentColumn++)
    {
        Console.Write(rectangleSymbol);
    }
    Console.WriteLine();
}



