using System;

class ReverseNumber
{
    public static void Main(string[] args)
    {
        // Input number from the user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find the count of digits
        int tempNumber = number;
        int digitCount = 0;

        while (tempNumber != 0)
        {
            digitCount++;
            tempNumber /= 10; // Reduce the number by removing the last digit
        }

        // Create an array to store digits
        int[] digits = new int[digitCount];

        // Store digits in the array
        int index = 0;
        while (number != 0)
        {
            digits[index] = number % 10; // Get the last digit
            number /= 10;               // Remove the last digit
            index++;
        }

        // Display the digits in reverse order
        Console.WriteLine("The number in reverse order is:");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]); // Print each digit
        }

        Console.WriteLine(); // For new line
    }
}

