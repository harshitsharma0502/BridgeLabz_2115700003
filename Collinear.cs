using System;

class CollinearityCheck
{
    static void Main()
    {
        Console.Write("Enter x1: "); // Take input for three points (x1, y1), (x2, y2), (x3, y3)
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());
        bool areCollinearUsingSlope = ArePointsCollinearUsingSlope(x1, y1, x2, y2, x3, y3);  // Check if the points are collinear using slope method
        Console.WriteLine("Points are collinear using slope formula: " + areCollinearUsingSlope);
        bool areCollinearUsingArea = ArePointsCollinearUsingArea(x1, y1, x2, y2, x3, y3);  // Check if the points are collinear using area of triangle method
        Console.WriteLine("Points are collinear using area formula: " + areCollinearUsingArea);
    }
    public static bool ArePointsCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3) // Method to check if three points are collinear using the slope formula
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return (slopeAB == slopeBC && slopeBC == slopeAC);
    }

    
    public static bool ArePointsCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3) // Method to check if three points are collinear using the area of triangle formula
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        return area == 0;
    }
}
