using System;

class SmallestAndLargest
{
    // Method to find the smallest and largest numbers among three integers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        // Initialize smallest and largest with the first number
        int smallest = number1;
        int largest = number1;

        // Compare the second number
        if (number2 < smallest)
        {
            smallest = number2;
        }
        if (number2 > largest)
        {
            largest = number2;
        }

        // Compare the third number
        if (number3 < smallest)
        {
            smallest = number3;
        }
        if (number3 > largest)
        {
            largest = number3;
        }

        return new int[] { smallest, largest }; // Return as an array
    }

    public static void Main(string[] args)
    {
        // Read inputs
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Call the method
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Display the results
        Console.WriteLine("Smallest number is: " + result[0]);
        Console.WriteLine("Largest number is: " + result[1]);
    }
}
