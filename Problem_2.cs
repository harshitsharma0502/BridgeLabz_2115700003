using System;

class NumberAnalysis
{
    public static void Main(string[] args)
    {
        // Define an integer array of 5 elements
        int[] numbers = new int[5];

        // Get user input for 5 numbers
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ":");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Check each number and display its type
        Console.WriteLine("\nNumber Analysis:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                Console.WriteLine("Number " + numbers[i] + " is positive and " 
                                  + (numbers[i] % 2 == 0 ? "even" : "odd") + ".");
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine("Number " + numbers[i] + " is negative.");
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is zero.");
            }
        }

        // Compare the first and last elements of the array
        Console.WriteLine("\nComparison of the first and last elements:");
        if (numbers[0] > numbers[1])
        {
            Console.WriteLine("The first element " + numbers[0] + " is greater than the last element " + numbers[1] + ".");
        }
        else if (numbers[0] < numbers[1])
        {
            Console.WriteLine("The first element " + numbers[0] + " is less than the last element " + numbers[1] + ".");
        }
        else
        {
            Console.WriteLine("The first element " + numbers[0] + " is equal to the last element " + numbers[1] + ".");
        }
    }
}