using System;

class MultiplicationTable
{
    public static void Main(string[] args)
    {
        // Get user input for the number
        Console.WriteLine("Enter a number to generate its multiplication table:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Define an integer array to store the multiplication table results
        int[] table = new int[10];

        // Generate the multiplication table and store results in the array
        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        // Display the multiplication table
        Console.WriteLine("\nMultiplication Table for " + number + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + table[i - 1]);
        }
    }
}