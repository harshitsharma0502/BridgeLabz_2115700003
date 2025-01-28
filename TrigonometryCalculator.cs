using System;

class TrigonometryCalculator
{
    // Method to calculate sine, cosine, and tangent of an angle
    public double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double radians = angle * Math.PI / 180;

        // Calculate trigonometric functions
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results in an array
        return new double[] { sine, cosine, tangent };
    }

    public static void Main(string[] args)
    {
        // Take user input for the angle in degrees
        Console.WriteLine("Enter the angle in degrees:");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Create an object of TrigonometryCalculator
        TrigonometryCalculator calculator = new TrigonometryCalculator();

        // Call the method to calculate sine, cosine, and tangent
        double[] results = calculator.CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine("Sine: "+ results[0].ToString("F4"));
        Console.WriteLine("Cosine: "+ results[1].ToString("F4"));
        Console.WriteLine("Tangent: "+ results[2].ToString("F4"));
    }
}
