using System;

public class PowerCalculator
{
    public static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter the base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        // Variable to store the result, initialized to 1
        int result = 1;

        // Loop to calculate the power
        for (int i = 1; i <= power; i++)
        {
            result *= number;  // Multiply the result by the base number
        }

        // Output the result using string concatenation
        Console.WriteLine(number + " raised to the power of " + power + " is: " + result);
    }
}