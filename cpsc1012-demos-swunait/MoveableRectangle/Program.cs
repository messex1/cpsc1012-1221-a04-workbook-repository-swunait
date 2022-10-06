/* Purpose: Print the borders of a rectangle shape on the screen 
 *          with a specific length (columns) and width (rows)
 * 
 * */

int columns = 5;
int rows = 5;
char lengthSymbol = '-';
char widthSybmbol = '|';
int columnCount = 0;
ConsoleKey key;
int keyPressCount = 0;

while (keyPressCount < 10)
{
    for (int currentRow = 1; currentRow <= rows; currentRow++)
    {
        Console.Write("".PadLeft(columnCount));
        for (int currentColumn = 1; currentColumn <= columns; currentColumn++)
        {
            // Print the rectangleSybmol if the cursor is currently at 
            // the first row or last row or first column or last column.
            // Otherwise print a single space
            if (currentRow == 1 || currentRow == rows)
            {
                Console.Write(lengthSymbol);
            }
            else if (currentColumn == 1 || currentColumn == columns)
            {
                Console.Write(widthSybmbol);
            }
            else
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine();
    }
    key = Console.ReadKey().Key;
    keyPressCount++;
    Console.Clear();
    if (key == ConsoleKey.RightArrow)
    {
        columnCount += 1;
    }
    else if (key == ConsoleKey.LeftArrow)
    {
        columnCount -= 1;
    }
    else if (key == ConsoleKey.DownArrow)
    {
        Console.WriteLine();
    }

}





