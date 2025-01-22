using System;

class KilometerToMilesConverter {
    public static void Main(string[] args) {
        // Take user input for kilometers
        Console.Write("Enter distance in kilometers: ");
        double distanceInKm = Convert.ToDouble(Console.ReadLine());

        // Conversion factor
        double kmToMilesFactor = 1.6;

        // Convert kilometers to miles
        double distanceInMiles = distanceInKm / kmToMilesFactor;

        // Display the result
        Console.WriteLine("The total miles is " + distanceInMiles + " miles for the given " + distanceInKm + " km");
    }
}
