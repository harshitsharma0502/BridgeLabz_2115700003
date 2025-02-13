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

        bool exists = HasPairWithSum(nums, target);
        Console.WriteLine(exists ? "Pair with given sum exists." : "No such pair found.");
    }

    static bool HasPairWithSum(int[] nums, int target)
    {
        Dictionary<int, bool> seenNumbers = new Dictionary<int, bool>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seenNumbers.ContainsKey(complement))
            {
                return true;
            }
            seenNumbers[nums[i]] = true;
        }
        return false;
    }
}
