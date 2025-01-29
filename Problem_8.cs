using System;

class FactorsOfNumber
{
    public static void Main(string[] args)
    {
        // Take input for a number
        Console.WriteLine("Enter a number to find its factors:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate the input
        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive number.");
            return;
        }

        // Initialize variables
        int maxFactor = 10; // Initial size of the array
        int[] factors = new int[maxFactor];
        int index = 0;

        // Find factors and store in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    // Increase the array size if needed
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    for (int j = 0; j < factors.Length; j++)
                    {
                        temp[j] = factors[j];
                    }
                    factors = temp;
                }
                factors[index] = i;
                index++;
            }
        }

        // Display the factors
        Console.WriteLine("Factors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}