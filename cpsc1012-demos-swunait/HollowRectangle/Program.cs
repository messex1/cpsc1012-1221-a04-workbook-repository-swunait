/* Purpose: Print the borders of a rectangle shape on the screen 
 *          with a specific length (columns) and width (rows)
 * 
 * */

int columns = 25;
int rows = 10;
char rectangleSymbol = '*';

for (int currentRow = 1; currentRow <= rows; currentRow++)
{
    for (int currentColumn = 1; currentColumn <= columns; currentColumn++)
    {
        // Print the rectangleSybmol if the cursor is currently at 
        // the first row or last row or first column or last column.
        // Otherwise print a single space
        if (currentRow == 1 || currentRow == rows 
            || currentColumn == 1 || currentColumn == columns)
        {
            Console.Write(rectangleSymbol);
        }
        else
        {
            Console.Write(' ');
        }
    }
    Console.WriteLine();
    
}



