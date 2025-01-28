
using System;

public class GreatestFactor
{
    public static void Main(string[] args)
    {
        // Input number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Variable to store the greatest factor
        int greatestFactor = 1;

        // Loop from number-1 to 1
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)  // Check if i is a factor of the number
            {
                greatestFactor = i;  // Assign i as the greatest factor
                break;  // Exit the loop once the greatest factor is found
            }
        }

        // Output the greatest factor
        Console.WriteLine("The greatest factor of " + number + " (besides itself) is: " + greatestFactor);
    }
}


