using System;

class Triangle
{
    // Method to calculate the number of rounds to complete 5KM
    // Parameter: array of triangle sides
    public double rounds(double[] side)
    {
        // Calculate the perimeter of the triangle
        double perimeter = side[0] + side[1] + side[2];
        
        // Calculate the number of rounds needed to complete 5KM
        double Rounds = 5000 / perimeter;
        
        // Return the calculated number of rounds
        return Rounds;
    }

    public static void Main(string[] args)
    {
        // Prompt the user to enter the sides of the triangle
        Console.WriteLine("Enter the sides of the Triangle in meters:");

        // Initialize an array to hold the 3 sides of the triangle
        double[] side = new double[3];

        // Read the sides of the triangle from user input
        for (int i = 0; i <= 2; i++)
        {
            // Prompt for each side
            Console.Write(string.Format("Side {0} : ", i + 1));
            side[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Create an instance of the Triangle class
        Triangle CalculateTriangle = new Triangle();

        // Call the rounds method to calculate the number of rounds
        double rounds = CalculateTriangle.rounds(side);

        // Display the result
        Console.WriteLine("Number of rounds to run 5KM is: " + rounds);
    }
}
