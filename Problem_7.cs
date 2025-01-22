using System;

class EarthVolumeCalculator {
    public static void Main(string[] args) {
        // Define Earth's radius
        double radiusInKm = 6378;

        // Conversion factor for cubic miles
        double kmToMilesFactor = 1.6;

        // Volume of a sphere formula
        double volumeInKm = (4.0 / 3) * Math.PI * Math.Pow(radiusInKm, 3);
        double volumeInMiles = volumeInKm / Math.Pow(kmToMilesFactor, 3);

        // Display the result
        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeInKm +" and in cubic miles is " + volumeInMiles);
    }
}
