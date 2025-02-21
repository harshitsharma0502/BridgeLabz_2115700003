using System;

class Program
{
    static void Main()
    {
        try
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                numbers[i] = num;
            }
            Console.Write("Enter an index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"Value at index {index}: {numbers[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }
}
