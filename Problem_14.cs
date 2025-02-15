using System;
using System.Text;

class FirstLastOccurrence
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the sorted array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the target value to search: ");
        int target = int.Parse(Console.ReadLine());

        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);

        StringBuilder result = new StringBuilder();

        if (first == -1)
            result.Append("Target not found in the array.");
        else
            result.Append("First occurrence at index ").Append(first)
                  .Append(", Last occurrence at index ").Append(last);

        Console.WriteLine(result.ToString());
    }

    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid; 
                right = mid - 1; // Move left to find the first occurrence
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1; // Move right to find the last occurrence
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}