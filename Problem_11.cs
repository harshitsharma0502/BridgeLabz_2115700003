using System;
using System.Text;

class RotationPointSearch
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        Console.WriteLine("Enter the rotated sorted array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int rotationIndex = FindRotationPoint(arr);
        
        StringBuilder result = new StringBuilder();
        result.Append("Rotation point index: ").Append(rotationIndex);
        
        Console.WriteLine(result.ToString());
    }

    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[right]) 
                left = mid + 1;  // Minimum element is in the right half
            else 
                right = mid;  // Minimum element is in the left half or at mid
        }

        return left; // The left index now points to the smallest element
    }
}
