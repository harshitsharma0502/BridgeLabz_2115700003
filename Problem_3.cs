using System;

class LargestDigitsFinder
{
    public static void Main(string[] args)
    {
        // Input the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize variables
        const int maxDigits = 10; // Maximum number of digits allowed
        int[] digits = new int[maxDigits]; // Array to store the digits
        int index = 0; // Index for the array

        // Extract digits from the number
        while (number != 0)
        {
            if (index == maxDigits)
            {
                Console.WriteLine("Maximum digits (" + maxDigits + ") reached. Remaining digits are ignored.");
                break;
            }

            digits[index] = number % 10; // Extract last digit
            number /= 10; // Remove last digit from the number
            index++;
        }

        // Variables to store the largest and second largest digits
        int largest = 0;
        int secondLargest = 0;

        // Find the largest and second-largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second largest
                largest = digits[i]; // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second largest
            }
        }

        // Display the results
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}