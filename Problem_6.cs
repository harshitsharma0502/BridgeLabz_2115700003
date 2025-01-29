using System;

class MeanHeightCalculator
{
    public static void Main(string[] args)
    {
        // Create a double array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0;

        // Get input values for heights from the user
        Console.WriteLine("Enter the heights of 11 football players (in cm):");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.WriteLine("Enter height of player " + (i + 1) + ":");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i]; // Add the height to the sum
        }

        // Calculate the mean height
        double mean = sum / heights.Length;

        // Display the mean height
        Console.WriteLine("\nThe mean height of the football team is: " + mean + " cm");
    }
}
