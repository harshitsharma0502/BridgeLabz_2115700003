using System;

class SquareSideCalculator {
    public static void Main(string[] args) {
        // Take user input for perimeter
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate side length
        double sideLength = perimeter / 4;

        // Display the result
        Console.WriteLine("The length of the side is " + sideLength + " whose perimeter is " + perimeter);
    }
}
