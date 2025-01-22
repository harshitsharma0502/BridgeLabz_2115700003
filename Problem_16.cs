using System;

class HandshakeCalculator {
    public static void Main(string[] args) {
        // Take user input for number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate maximum handshakes using combination formula
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Display the result
        Console.WriteLine("The maximum number of possible handshakes is " + maxHandshakes);
    }
}
