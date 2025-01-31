using System;

namespace PrimeNumberChecker
{
    class CheckNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a prime number:");
            int number = GetIntegerInput("Enter a positive integer: ");

            if (IsPrime(number))
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }

        static int GetIntegerInput(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; // Numbers less than or equal to 1 are not prime
            }

            if (number == 2)
            {
                return true; // 2 is the only even prime number
            }

            if (number % 2 == 0)
            {
                return false; // Exclude even numbers greater than 2
            }

            // Check for factors up to the square root of the number
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false; // Found a factor, so the number is not prime
                }
            }

            return true; // No factors found, the number is prime
        }
    }
}