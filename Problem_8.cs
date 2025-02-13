using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the array elements (space-separated): ");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int longestSequence = LongestConsecutiveSequence(nums);
        Console.WriteLine($"Length of the longest consecutive sequence: {longestSequence}");
    }

    static int LongestConsecutiveSequence(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>();
        foreach (int num in nums)
        {
            numSet.Add(num);
        }

        int longestStreak = 0;

        foreach (int num in nums)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}
