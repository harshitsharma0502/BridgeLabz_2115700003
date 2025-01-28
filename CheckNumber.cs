using System;

class CheckNumber
{
    // Method to check whether a number is positive, negative, or zero
    public int numbers(int number)
    {
        // Return -1 for negative numbers
        if (number < 0)
            return -1;
        // Return 1 for positive numbers
        else if (number > 0)
            return 1;
        // Return 0 for zero
        else
            return 0;
    }

    public static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter the Number:");
        
        // Read the number from the user and convert it to an integer
        int number = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the CheckNumber class
        CheckNumber check = new CheckNumber();

        // Call the numbers method to determine the type of number
        int type = check.numbers(number);

        // Display the result based on the return value
        if (type == 0)
            Console.WriteLine("Number is zero");
        else if (type == 1)
            Console.WriteLine("Number is positive");
        else
            Console.WriteLine("Number is negative");
    }
}
