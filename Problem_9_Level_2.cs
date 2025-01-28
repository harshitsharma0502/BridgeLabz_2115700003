using System;

public class DigitFrequency
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        long number = long.Parse(Console.ReadLine());

        // Convert the number to string to easily access each digit
        string numStr = number.ToString();

        // Create an array to store the frequency of each digit (0-9)
        int[] frequency = new int[10];

        // Loop through each digit in the number and update the frequency array
        foreach (char digitChar in numStr)
        {
            // Convert the character digit to an integer
            int digit = int.Parse(digitChar.ToString());
            frequency[digit]++;
        }

        // Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + ": " + frequency[i] + " times");
            }
        }
    }
}
