using System;

class ChocolateDivision
{
    // Method to find the number of chocolates each child gets and the remainder
    public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;  // Quotient: chocolates each child gets
        int remainingChocolates = numberOfChocolates % numberOfChildren;  // Remainder: leftover chocolates

        return new int[] { chocolatesPerChild, remainingChocolates };  // Return both values in an array
    }

    public static void Main(string[] args)
    {
        // Take user input for number of chocolates and number of children
        Console.WriteLine("Enter the number of chocolates:");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of children:");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Call the method to find the number of chocolates each child gets and the remainder
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // Display the results
        Console.WriteLine("Each child will get: " + result[0] + " chocolates.");
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }
}
