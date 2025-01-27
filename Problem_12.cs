using System;

public class MultipleFinder
{
    public static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Loop backward from 100 to 1
        Console.WriteLine("Multiples of " + number + " below 100 are:");
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)  // Check if i is a multiple of number
            {
                Console.WriteLine(i);  // Print the multiple
            }
        }
    }
}