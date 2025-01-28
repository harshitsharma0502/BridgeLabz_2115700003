using System;

class Sum
{
    // Method to calculate the sum of the first N natural numbers
    public int SumOfNatural(int number)
    {
        int total = 0; // Initialize total to 0
        
        // Use a while loop to add numbers from 'number' down to 1
        while (number > 0)
        {
            total = total + number; // Add the current number to total
            number--;              // Decrease the number by 1
        }
        return total; // Return the total sum
    }

    public static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter the number:");
        
        // Read the input and convert it to an integer
        int number = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the Sum class
        Sum sum = new Sum();

        // Call the SumOfNatural method and display the result
        Console.WriteLine("The sum of " + number + " natural numbers is: " + sum.SumOfNatural(number));
    }
}
