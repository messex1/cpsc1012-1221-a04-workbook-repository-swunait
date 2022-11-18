using RectangleApp;

// Create a Rectangle object for the gate of a pen
Rectangle gate = new Rectangle(4, 8);
// Print the area of the gate
Console.WriteLine($"Gate area {gate.Area()}");
// Compute the gate cost
double gateCost = gate.Area() * 8;
// Print the gate cost
Console.WriteLine($"Gate cost {gateCost:C}");

// Create a Rectangle object for the side wall of the pen
Rectangle sideWall = new Rectangle(12, 15);
Rectangle backWall = new Rectangle(12, 10);
Rectangle gateInPen = new Rectangle(12, 8);
// Compute the wall cost
double totalWallArea = sideWall.Area() * 2 + backWall.Area() * 2 - gateInPen.Area();
double totalWallCost = totalWallArea * 4;
Console.WriteLine($"Wall cost {totalWallCost:C}");