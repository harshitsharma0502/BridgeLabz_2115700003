using System;

public class QuickSort
{
    public static int Partition(int[] arr, int start, int end)
    {
        int pivotIndex = start;
        int pivotElement = arr[start];
        int count = 0;
        for (int k = start + 1; k <= end; k++) // Changed 'i' to 'k'
        {
            if (arr[k] <= pivotElement)
                count++;
        }
        int rightIndex = start + count;
        Swap(arr, pivotIndex, rightIndex);
        pivotIndex = rightIndex;

        int i = start, j = end;
        while (i < pivotIndex && j > pivotIndex)
        {
            while (arr[i] <= pivotElement) i++;
            while (arr[j] > pivotElement) j--;

            if (i < pivotIndex && j > pivotIndex)
                Swap(arr, i, j);
        }

        return pivotIndex;
    }
    public static void QuickSortAlgo(int[] arr, int start, int end)
    {
        if (start >= end)
            return;

        int p = Partition(arr, start, end);
        QuickSortAlgo(arr, start, p - 1);
        QuickSortAlgo(arr, p + 1, end);
    }
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    public static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int n = arr.Length;
        QuickSortAlgo(arr, 0, n - 1);

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
