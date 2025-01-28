using System;

class Handshakes
{
    // Method to calculate the maximum number of handshakes
    // This method takes the total number of people as input 
    // and returns the maximum number of handshakes possible.
    public int CalculateHandshake(int numberOfStudents )
    {
        // Formula to calculate maximum handshakes: (n × (n - 1)) / 2
        // This is derived from the combination formula C(n, 2), 
        // where each pair of people shakes hands once.
        int maxHandshakes = (numberOfStudents  * (numberOfStudents  - 1)) / 2;
        return maxHandshakes;
    }

    public static void Main(string[] args)
    {
        // Prompt the user to enter the number of people
        Console.WriteLine("Enter the number");
        int numberOfStudents  = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the Handshakes class to call the method
        Handshakes handShakeCalculator = new Handshakes();

        // Call the method to calculate the maximum number of handshakes
        int maxHandshakes = handShakeCalculator.CalculateHandshake(numberOfStudents );

        // Display the result to the user
        Console.WriteLine("Maximum number of possible handshakes are: " + maxHandshakes);
    }
}
