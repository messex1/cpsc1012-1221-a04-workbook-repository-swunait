/*
	Trace Table for Filled Triangle with a base of 5

	Row		Column		Column <= Row	Output	
	---		------		-------------	------
	1		
			1			1 <= 1 is T		*
			2			2 <= 1 is F
	2
			1			1 <= 2 is T		*	
			2			2 <= 2 is T		 *
			3			3 <= 2 is F	
										** (actual line output)
	3			
			1			1 <= 3 is T		*	
			2			2 <= 3 is T		 *
			3			3 <= 3 is T		  *
			4			4 <= 3 is F	
										*** (actual line output)
	4
			1		1 <= 4 is T	*	
			2		2 <= 4 is T	 *
			3		3 <= 4 is T	  *
			4		4 <= 4 is T	   *	
			5		5 <= 4 is F	
										**** (actual line output)
	5
			1		1 <= 5 is T	*	
			2		2 <= 5 is T	 *
			3		3 <= 5 is T	  *
			4		4 <= 5 is T	   *
			5		5 <= 5 is T	    *
										***** (actual line output)
 * 
 * 
 * 
 * 
 * */
int triangleBase = 15;

for (int currentRow = 1; currentRow <= triangleBase; currentRow += 1)
{
    for (int currentColumn = 1; currentColumn <= currentRow;  currentColumn += 1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
