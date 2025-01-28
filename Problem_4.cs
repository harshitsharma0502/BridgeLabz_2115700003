
using System;

class PrimeNumberChecker
{
    public static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize isPrime to true
        bool isPrime = true;

        // Check if the number is greater than 1
        if (number <= 1)
        {
            isPrime = false; // Numbers less than or equal to 1 are not prime
        }
        else
        {
            // Loop through numbers from 2 to number - 1
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) // If divisible by i, it's not a prime number
                {
                    isPrime = false;
                    break;
                }
            }
        }

        // Output the result
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}

