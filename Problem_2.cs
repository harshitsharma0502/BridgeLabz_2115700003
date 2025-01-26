using System;

class FriendComparison
{
    public static void Main(string[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input for age and height
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter the age of " + friends[i] + ":");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height (in cm) of " + friends[i] + ":");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Determine the youngest friend
        int minAgeIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[minAgeIndex])
            {
                minAgeIndex = i;
            }
        }

        // Determine the tallest friend
        int maxHeightIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > heights[maxHeightIndex])
            {
                maxHeightIndex = i;
            }
        }

        // Display the results
        Console.WriteLine("\nThe youngest friend is " + friends[minAgeIndex] + " with an age of " + ages[minAgeIndex] + ".");
        Console.WriteLine("The tallest friend is " + friends[maxHeightIndex] + " with a height of " + heights[maxHeightIndex] + " cm.");
    }
}
