/* Purpose: Compute the area of a hexagon
 * 
 * Inputs:  side of the hexagon
 * 
 * Outputs: area of the hexagon
 * 
 * Algorithm:   1) Prompt and read in the side of the hexagon
 *              2) Compute the area of the hexagon using the formula:
 *                  area = 3 * Math.Sqrt(3) * side * side / 2
 *              3) Display the area of the hexagon    
 *
 * Last Modified:   2022-09-12
 * 
 * */

// Declare variables for inputs (side) and outputs (area)
double side;
double area;

// Prompt and read in the inputs for side
Console.Write("Enter the length of the side: ");
side = double.Parse(Console.ReadLine());

// Compute the area 
//area = 3 * Math.Sqrt(3) * side * side / 2;
area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
// Round the area to 4 decimal place
area = Math.Round(area, 4);

// Display the area
Console.WriteLine($"The area of the hexagon is {area}");
