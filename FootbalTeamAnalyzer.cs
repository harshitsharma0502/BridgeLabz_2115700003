using System;

class FootballTeamHeightAnalyzer
{
    static void Main(string[] args)
    {
        int[] heights = new int[11];
        Random random = new Random();
        for (int i = 0; i < heights.Length; i++) // Populate the array with random heights between 150 and 250 cm
        {
            heights[i] = random.Next(150, 251);
        }

        Console.WriteLine("Player Heights (in cm):");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine("\n");

        int sum = CalculateSum(heights);
        double mean = CalculateMean(sum, heights.Length);
        int shortest = FindShortestHeight(heights);
        int tallest = FindTallestHeight(heights);

        Console.WriteLine("Sum of Heights: " + sum + " cm");
        Console.WriteLine("Mean Height: " + mean + " cm");
        Console.WriteLine("Shortest Player Height: " + shortest + " cm");
        Console.WriteLine("Tallest Player Height: " + tallest + " cm");
    }
    static int CalculateSum(int[] heights) // Method to calculate the sum of all elements
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }
    static double CalculateMean(int sum, int count) // Method to calculate the mean height
    {
        return (double)sum / count;
    }
    static int FindShortestHeight(int[] heights) // Method to find the shortest height
    {
        int shortest = Int32.MaxValue;
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }
    static int FindTallestHeight(int[] heights) // Method to find the tallest height
    {
        int tallest = Int32.MinValue;
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
