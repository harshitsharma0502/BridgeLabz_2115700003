using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the array elements");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        List<(int, int)> subarrays = FindZeroSumSubarrays(nums);

        if (subarrays.Count == 0)
        {
            Console.WriteLine("No zero-sum subarrays found.");
        }
        else
        {
            Console.WriteLine("Zero-sum subarrays:");
            foreach (var (start, end) in subarrays)
            {
                Console.WriteLine($"Start: {start}, End: {end}");
            }
        }
    }

    static List<(int, int)> FindZeroSumSubarrays(int[] nums)
    {
        List<(int, int)> result = new List<(int, int)>();
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;
        sumMap[0] = new List<int> { -1 };

        for (int i = 0; i < nums.Length; i++)
        {
            cumulativeSum += nums[i];
            if (sumMap.ContainsKey(cumulativeSum))
            {
                foreach (int start in sumMap[cumulativeSum])
                {
                    result.Add((start + 1, i));
                }
            }
            if (!sumMap.ContainsKey(cumulativeSum))
            {
                sumMap[cumulativeSum] = new List<int>();
            }
            sumMap[cumulativeSum].Add(i);
        }

        return result;
    }
}
