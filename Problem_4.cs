using System;

class NaturalNumberCheck
{
    public static void Main(string[] args)
    {
        // Ask the user to enter a number
        Console.WriteLine("Enter a number: ");
        try
        {
            // Convert the input to an integer
            int number = int.Parse(Console.ReadLine());

            // Check if the number is a natural number (0 or positive)
            if (number >= 0)
            {
                // Calculate the sum of n natural numbers
                int sum = number * (number + 1) / 2;
                Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
            }
            else
            {
                Console.WriteLine("The number " + number + " is not a natural number.");
            }
        }
        catch
        {
            // Handle invalid input (non-numeric values)
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}
