using System;

class TriangleAreaCalculator {
    public static void Main(string[] args) {
        // Take user input for base and height
        Console.Write("Enter the base of the triangle in cm: ");
        double baseInCm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle in cm: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // Calculate area
        double areaInSquareCm = 0.5 * baseInCm * heightInCm;
        double areaInSquareInches = areaInSquareCm / 6.4516;

        // Display the results
        Console.WriteLine("The area of the triangle is " + areaInSquareCm + " square centimeters and " + areaInSquareInches + " square inches");
    }
}
