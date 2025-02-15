using System;
using System.Text;

class PeakElementSearch
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

        int peakIndex = FindPeakElement(arr);

        StringBuilder result = new StringBuilder();
        result.Append("Peak element: ").Append(arr[peakIndex]).Append(" at index ").Append(peakIndex);
        
        Console.WriteLine(result.ToString());
    }

    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[mid + 1]) 
                right = mid; // Move left if mid is greater than the next element
            else 
                left = mid + 1; // Move right if mid is smaller than the next element
        }

        return left; // Peak element index
    }
}
