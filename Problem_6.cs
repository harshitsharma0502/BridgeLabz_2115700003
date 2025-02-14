using System;

public class HeapSort
{
    public static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            Swap(ref arr[i], ref arr[largest]);
            Heapify(arr, n, largest);
        }
    }

    public static void HeapSortAlgo(int[] arr, int n)
    {
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            Swap(ref arr[0], ref arr[i]);
            Heapify(arr, i, 0);
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    public static void Main()
    {
        int[] salaries = { 50000, 70000, 30000, 90000, 60000, 40000 };
        int n = salaries.Length;

        Console.WriteLine("Original Salary Demands:");
        PrintArray(salaries);

        HeapSortAlgo(salaries, n);

        Console.WriteLine("Sorted Salary Demands (Ascending Order):");
        PrintArray(salaries);
    }
}
