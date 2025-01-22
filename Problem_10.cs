using System;

class HeightConverter {
    public static void Main(string[] args) {
        // Take user input for height in cm
        Console.Write("Enter your height in centimeters: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double cmToInchesFactor = 2.54;
        double inchesToFeetFactor = 12;

        // Convert height to inches and feet
        double heightInInches = heightInCm / cmToInchesFactor;
        double heightInFeet = Math.Floor(heightInInches / inchesToFeetFactor);
        double remainingInches = heightInInches % inchesToFeetFactor;

        // Display the result
        Console.WriteLine("Your height in cm is " + heightInCm + ", in feet is " + heightInFeet + " and in inches is " + remainingInches);
    }
}
