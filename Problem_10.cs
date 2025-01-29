 using System;

class Program
{
    static void Main()
    {
        // Take user input
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if input is a positive integer
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Create a string array to save the results
        string[] results = new string[number + 1];

        // Loop through numbers from 1 to the input number
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz";
            else if (i % 3 == 0)
                results[i] = "Fizz";
            else if (i % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = i.ToString();
        }

        // Display results in the desired format
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + results[i]);
        }
    }
}