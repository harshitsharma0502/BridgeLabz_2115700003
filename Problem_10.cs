using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the array elements (space-separated): ");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.Write("Enter the target sum: ");
        int target = int.Parse(Console.ReadLine());

        int[] result = TwoSum(nums, target);
        if (result.Length == 2)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("No pair found.");
        }
    }

    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }
            numMap[nums[i]] = i;
        }
        return new int[0];
    }
}
