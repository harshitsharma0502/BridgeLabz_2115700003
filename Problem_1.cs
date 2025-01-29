using System;

public class VotingEligibility
{
    public static void Main(string[] args)
    {
        // Define an array of 10 integers to store the ages of the students
        int[] ages = new int[10];

        // Loop to take input for each student's age
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter the age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            // Check if the age is negative
            if (ages[i] < 0)
            {
                Console.WriteLine("Invalid age entered. Please enter a positive value.");
                i--; // Decrement the index to ask for the age again
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine("The student with age " + ages[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with age " + ages[i] + " cannot vote.");
            }
        }
    }
}