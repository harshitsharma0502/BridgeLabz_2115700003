using System;

class DistanceConverter {
    public static void Main(string[] args) {
        // Define the distance in kilometers
        double distanceInKilometers = 10.8;

        // Conversion factor from kilometers to miles
        double kilometersToMilesFactor = 1.6;

        // Convert the distance to miles
        double distanceInMiles = distanceInKilometers / kilometersToMilesFactor;

        // Display the result
        Console.WriteLine("The distance " + distanceInKilometers + " km in miles is " + distanceInMiles);
    }
}
