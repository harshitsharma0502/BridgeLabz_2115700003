using System;

class Geometry
{
    static void Main()
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2); // Call method to calculate Euclidean distance
        Console.WriteLine("Euclidean Distance: " + distance);
        double[] lineEquation = FindLineEquation(x1, y1, x2, y2);  // Call method to calculate the equation of the line
        Console.WriteLine("Equation of the line: y = " + lineEquation[0] + "x + " + lineEquation[1]);
    }

    
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2) // Method to calculate the Euclidean distance between two points
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)  // Method to find the equation of the line given two points
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }
}
