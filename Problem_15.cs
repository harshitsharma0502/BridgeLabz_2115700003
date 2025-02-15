using System;
using System.Text;

class LinearBinarySearchChallenge
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the target value to search: ");
        int target = int.Parse(Console.ReadLine());

        int missingPositive = FindFirstMissingPositive(arr, size);
        BubbleSort(arr, size);  // Sort for binary search
        int targetIndex = BinarySearch(arr, 0, size - 1, target);

        StringBuilder result = new StringBuilder();
        result.Append("First missing positive integer: ").Append(missingPositive).Append("\n");

        if (targetIndex == -1)
            result.Append("Target value not found.");
        else
            result.Append("Target value found at index ").Append(targetIndex);

        Console.WriteLine(result.ToString());
    }

    static int FindFirstMissingPositive(int[] arr, int size)
    {
        for (int i = 1; i <= size; i++) // Checking sequentially for missing number
        {
            bool found = false;
            for (int j = 0; j < size; j++)
            {
                if (arr[j] == i)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
                return i;
        }
        return size + 1; // If no missing found, return next positive integer
    }

    static void BubbleSort(int[] arr, int size)
    {
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static int BinarySearch(int[] arr, int left, int right, int target)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1; // Target not found
    }
}
