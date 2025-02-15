using System;
using System.Text;

class FirstNegativeSearch
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];
        StringBuilder result = new StringBuilder(); // StringBuilder to store output

        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool found = false;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] < 0)
            {
                result.Append("First negative number: ").Append(numbers[i]);
                found = true;
                break;
            }
        }

        if (!found)
            result.Append("No negative number found.");

        Console.WriteLine(result.ToString());
    }
}
