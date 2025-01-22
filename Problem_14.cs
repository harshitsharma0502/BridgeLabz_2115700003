using System;

class DistanceConverterFeet {
    public static void Main(string[] args) {
        // Take user input for distance in feet
        Console.Write("Enter distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double feetToYardsFactor = 3;
        double yardsToMilesFactor = 1760;

        // Convert distance
        double distanceInYards = distanceInFeet / feetToYardsFactor;
        double distanceInMiles = distanceInYards / yardsToMilesFactor;

        // Display the results
        Console.WriteLine("The distance in yards is " + distanceInYards + " and in miles is " + distanceInMiles);
    }
}
