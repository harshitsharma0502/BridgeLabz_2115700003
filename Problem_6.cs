using System;

class FizzBuzz
{
    public static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Initialize the counter variable
            int i = 1;

            // While loop to go from 1 to the entered number
            while (i <= number)
            {
                // Check for multiples of 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                // Increment the counter
                i++;
            }
        }
    }
}