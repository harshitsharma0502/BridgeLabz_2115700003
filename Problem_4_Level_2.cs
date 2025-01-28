using System;

class FindLargestAndSecondLargest
{
    public static void Main(string[] args)
    {
        // Variables
        int number;
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Input from user
        Console.WriteLine("Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());

        // Store digits in the array and dynamically resize if needed
        while (number != 0)
        {
            // If index equals maxDigit, increase maxDigit and resize the array
            if (index == maxDigit)
            {
                maxDigit += 10; // Increase maxDigit by 10
                int[] temp = new int[maxDigit];
                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i]; // Copy existing digits to temp array
                }
                digits = temp; // Assign the temp array back to digits
            }

            digits[index] = number % 10; // Get the last digit
            number = number / 10;        // Remove the last digit
            index++;
        }

        // Initialize largest and second largest
        int largest = 0;
        int secondLargest = 0;

        // Find largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second largest
                largest = digits[i];     // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second largest
            }
        }

        // Output the largest and second largest
        Console.WriteLine("The largest digit is: " + largest);
        Console.WriteLine("The second largest digit is: " + secondLargest);
    }
}
