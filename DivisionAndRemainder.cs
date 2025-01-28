using System;

class DivisionAndRemainder
{
    // Method to find the quotient and remainder
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;  // Division operator for quotient
        int remainder = number % divisor; // Modulus operator for remainder

        return new int[] { quotient, remainder };  // Return both as an array
    }

    public static void Main(string[] args)
    {
        // Take user input for number and divisor
        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the divisor:");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // Call the method to find quotient and remainder
        int[] result = FindRemainderAndQuotient(number, divisor);

        // Display the quotient and remainder
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }
}
