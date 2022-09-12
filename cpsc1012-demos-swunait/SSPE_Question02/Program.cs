/* Purpose: This program computes the area and volume of a cylinder
 * 
 * Inputs:  radius of cylinder
 *          length of cylinder
 *  
 * Outputs: Computed area and volume of cylinder
 * 
 * Algorithm:   1) Prompt and read in the radius and length of cylinder
 *              2) Compute the area and volume of cylinder as follows:
 *                      area = radius * radius * 3.14
 *                      volume = area * length
 *              3) Display the computed area and volume of cylinder         
 * 
 * */

// Declare variables for inputs (radius, length) and outputs (area and volume)
double radius;
double length;
double  area,
        volume;

// Prompt and read in the radius and length of cylinder
Console.Write("Enter the radius of the cylinder: ");
radius = double.Parse(Console.ReadLine());
Console.Write("Enter the length of the cylinder: ");
length = double.Parse(Console.ReadLine());

// Compute the area and volume of cylinder
area = radius * radius * Math.PI;
volume = area * length;
// Round the area to 4 decimal place
area = Math.Round(area, 4);
// Round the volume to 1 decimal place
volume = Math.Round(volume, 1);

//Display the computed area and volume of cylinder    
Console.WriteLine($"The area is {area}");
Console.WriteLine($"The volume is {volume}");