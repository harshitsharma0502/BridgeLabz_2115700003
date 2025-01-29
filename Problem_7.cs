using System;

class OddEvenArrays
{
    public static void Main(string[] args)
    {
        // Get input from the user
        Console.WriteLine("Enter a natural number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the entered number is a natural number
        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number greater than 0.");
            return;
        }

        // Define arrays for odd and even numbers
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];
        int oddIndex = 0;
        int evenIndex = 0;

        // Iterate from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        // Print odd numbers array
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        // Print even numbers array
        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
}