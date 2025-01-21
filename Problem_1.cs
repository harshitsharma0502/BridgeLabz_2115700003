using System;

class FindAge {
    public static void Main(string[] args) {
        // Assign birth year and current year
        int birthYear = 2000;
        int currentYear = 2024;

        // Calculate age
        int age = currentYear - birthYear;

        // Display Harry's age
        Console.WriteLine("Harry's age in " + currentYear + " is " + age);
    }
}
