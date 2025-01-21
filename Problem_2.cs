using System;

class CalculateAverage {
    public static void Main(string[] args) {
        // Assign marks for each subject
        int mathsMarks = 94;
        int physicsMarks = 95;
        int chemistryMarks = 96;

        // Calculate average percentage
        double averageMarks = (mathsMarks + physicsMarks + chemistryMarks) / 3.0;

        // Display the average marks
        Console.WriteLine("Sam's average mark in PCM is " + averageMarks);
    }
}
