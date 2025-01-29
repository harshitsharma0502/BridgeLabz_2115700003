using System;

class StoreAndSum
{
    public static void Main(string[] args)
    {
        // Create an array of 10 elements and initialize total and index
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        // Infinite while loop to get user input
        Console.WriteLine("Enter up to 10 positive numbers (0 or negative to stop):");
        while (true)
        {
            Console.WriteLine("Enter number " + (index + 1) + ":");
            double input = Convert.ToDouble(Console.ReadLine());

            // Break if the user enters 0 or a negative number
            if (input <= 0)
            {
                break;
            }

            // Assign number to array and increment index
            numbers[index] = input;
            index++;

            // Break if the index reaches the maximum size of the array
            if (index == 10)
            {
                break;
            }
        }

        // Calculate the total using a for loop
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }

        // Display all numbers and the total
        Console.WriteLine("\nYou entered the following numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Total sum of numbers: " + total);
    }
}