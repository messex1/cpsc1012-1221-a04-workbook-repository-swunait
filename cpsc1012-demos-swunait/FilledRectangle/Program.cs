/* Purpose: Print a rectangle shape on the screen with a specific length (columns)
 *          and width (rows)
Trace Table for Filled Rectangle with a length(column) of 5 and width(row) of 3

	Row 	Column		Column <= Length	Output	
	---		------		----------------	------
	1		
			1			1 <= 5 is T			*
			2			2 <= 5 is T			 *
			3			3 <= 5 is T			  *
			4			4 <= 5 is T			   *
			5			5 <= 5 is T			    *
											***** (end result)
	2
			1			1 <= 5 is T			*
			2			2 <= 5 is T			 *
			3			3 <= 5 is T			  *
			4			4 <= 5 is T			   *
			5			5 <= 5 is T			    *							
											***** (end result)
	3			
			1			1 <= 5 is T			*
			2			2 <= 5 is T			 *
			3			3 <= 5 is T			  *
			4			4 <= 5 is T			   *
			5			5 <= 5 is T			    *
											***** (end result)
											
											
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



