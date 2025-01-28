using System;

public class FactorFinder
{
    public static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Loop to find factors
        Console.WriteLine("Factors of " + number + " are:");
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)  // Check if i is a factor of number
            {
                Console.WriteLine(i);  // Print the factor
            }
        }
    }
}