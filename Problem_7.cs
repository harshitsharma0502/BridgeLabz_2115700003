using System;

public class CountingSort
{
    public static void CountingSortAlgo(int[] arr, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
            count[arr[i] - min]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }

        for (int i = 0; i < arr.Length; i++)
            arr[i] = output[i];
    }
    public static void Main()
    {
        int[] ages = { 12, 15, 14, 18, 11, 10, 13, 17, 12, 16, 18, 14 };
        int n = ages.Length;
        int minAge = 10, maxAge = 18;
        CountingSortAlgo(ages, minAge, maxAge);
        Console.WriteLine("Sorted Student Ages:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(ages[i] + " ");
        }
    }
}
