using System;

class VotingEligibility
{
    public static void Main(string[] args)
    {
        // Ask the user to enter their age
        Console.WriteLine("Enter the person's age: ");
        try
        {
            // Convert the input to an integer
            int age = int.Parse(Console.ReadLine());

            // Check if the person is eligible to vote
            if (age >= 18)
            {
                Console.WriteLine("The person's age is " + age + " and can vote.");
            }
            else
            {
                Console.WriteLine("The person's age is " + age + " and cannot vote.");
            }
        }
        catch
        {
            // Handle invalid input
            Console.WriteLine("Invalid input! Please enter a valid integer for age.");
        }
    }
}
