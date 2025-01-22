using System;

class CalculateAverage {
    public static void Main(string[] args) {
        // Assign marks to individual subjects
        int mathematicsScore = 94;
        int physicsScore = 95;
        int chemistryScore = 96;

        // Calculate the average percentage
        double averagePercentage = (mathematicsScore +     physicsScore + chemistryScore) / 3.0;
        // Display the result
        Console.WriteLine("Sam's average mark in PCM is "   +averagePercentage);
    }
}
