using System;

class MultiplicationTable
{
    public static void Main(string[] args)
    {
        // Take user input for the number
        Console.WriteLine("Enter a number to find its multiplication table from 6 to 9:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Define an array to store the multiplication results
        int[] multiplicationResult = new int[4];

        // Calculate multiplication results for 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }

        // Display the results
        Console.WriteLine("\nMultiplication Table:");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
        }
    }
}