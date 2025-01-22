using System;

class PenDivider {
    public static void Main(string[] args) {
        // Define the total pens and number of students
        int totalPens = 14;
        int numberOfStudents = 3;

        // Calculate pens per student and remainder
        int pensPerStudent = totalPens / numberOfStudents;
        int remainingPens = totalPens % numberOfStudents;

        // Display the result
        Console.WriteLine("The Pen Per Student is " + pensPerStudent + " and the remaining pen not distributed is " + remainingPens);
    }
}
