using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of side 1: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the length of side 2: ");
        string input2 = Console.ReadLine();

        Console.Write("Enter the length of side 3: ");
        string input3 = Console.ReadLine();

        // Validate input and parse it
        if (double.TryParse(input1, out double side1) && side1 > 0 &&
            double.TryParse(input2, out double side2) && side2 > 0 &&
            double.TryParse(input3, out double side3) && side3 > 0)
        {
            // Check for triangle inequality theorem
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numbers for the sides of the triangle.");
        }
    }
}
