using System;

public class Circle
{
    // Attribute
    private double radius;

    // Constructor to initialize radius
    public Circle(double Radius)
    {
        radius = Radius;
    }

    // Method to calculate area of the circle
    public double CalculateArea()
    {
        return 3.14 * radius * radius;
    }

    // Method to calculate circumference of the circle
    public double CalculateCircumference()
    {
        return 2 * 3.14 * radius;
    }

    // Method to display area and circumference
    public void DisplayDetails()
    {
        Console.WriteLine("Area of the Circle: " + CalculateArea());
        Console.WriteLine("Circumference of the Circle: " + CalculateCircumference());
    }
}

public class Problem_2
{
    public static void Main(string[] args)
    {
        // Taking input from the user
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());

        // Create Circle object
        Circle circle = new Circle(radius);

        // Display circle details
        circle.DisplayDetails();
    }
}
