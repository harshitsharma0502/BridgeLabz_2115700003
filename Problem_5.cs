using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of petrol pumps: ");
        int n = int.Parse(Console.ReadLine());
        int[] petrol = new int[n];
        int[] distance = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter petrol and distance for pump {i + 1} (space-separated): ");
            string[] input = Console.ReadLine().Split();
            petrol[i] = int.Parse(input[0]);
            distance[i] = int.Parse(input[1]);
        }

        int start = CircularTour(petrol, distance, n);
        Console.WriteLine(start == -1 ? "No possible tour" : $"Start at petrol pump {start}");
    }

    static int CircularTour(int[] petrol, int[] distance, int n)
    {
        int start = 0, surplus = 0, deficit = 0;

        for (int i = 0; i < n; i++)
        {
            surplus += petrol[i] - distance[i];
            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        return (surplus + deficit) >= 0 ? start : -1;
    }
}
