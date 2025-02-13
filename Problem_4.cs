using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the array elements (space-separated): ");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.Write("Enter the window size (k): ");
        int k = int.Parse(Console.ReadLine());

        int[] result = SlidingWindowMaximum(nums, k);
        Console.WriteLine("Maximum elements in each sliding window:");
        Console.WriteLine(string.Join(" ", result));
    }

    static int[] SlidingWindowMaximum(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return new int[0];

        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
                deque.RemoveFirst();

            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                deque.RemoveLast();

            deque.AddLast(i);

            if (i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }

        return result.ToArray();
    }
}
