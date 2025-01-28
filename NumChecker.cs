using System;
using System.Linq;

class NumberChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Number of digits: " + GetDigitCount(number));

        int[] digits = GetDigits(number);
        Console.WriteLine("Digits array: " + string.Join(", ", digits));

        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number, digits));

        FindLargestAndSecondLargest(digits);
        FindSmallestAndSecondSmallest(digits);
    }
    public static int GetDigitCount(int number) // Method to find the count of digits in the number
    {
        return number.ToString().Length;
    }

    public static int[] GetDigits(int number) // Method to store the digits of the number in a digits array
    {
        return number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    }

    public static bool IsDuckNumber(int[] digits) // Method to check if a number is a duck number
    {
        return digits.Length > 1 && digits.Any(digit => digit == 0); // A duck number must not start with 0 but can contain it later
    }

    public static bool IsArmstrongNumber(int number, int[] digits) // Method to check if a number is an Armstrong number
    {
        int power = digits.Length;
        int sum = digits.Sum(digit => (int)Math.Pow(digit, power));
        return sum == number;
    }

    public static void FindLargestAndSecondLargest(int[] digits)
    {
        int max1 = Int32.MinValue, max2 = Int32.MinValue;

        foreach (int digit in digits)
        {
            if (digit > max1)
            {
                max2 = max1;
                max1 = digit;
            }
            else if (digit > max2)
            {
                max2 = digit;
            }
        }

        if (max2 == Int32.MinValue)
        {
            Console.WriteLine("Largest: " + max1 + " (no distinct second largest)");
        }
        else
        {
            Console.WriteLine("Largest: " + max1 + ", Second Largest: " + max2);
        }
    }

    public static void FindSmallestAndSecondSmallest(int[] digits) // Method to find the smallest and second smallest elements
    {
        int min1 = Int32.MaxValue, min2 = Int32.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < min1)
            {
                min2 = min1;
                min1 = digit;
            }
            else if (digit < min2)
            {
                min2 = digit;
            }
        }

        if (min2 == Int32.MaxValue)
        {
            Console.WriteLine("Smallest: " + min1 + " (no distinct second smallest)");
        }
        else
        {
            Console.WriteLine("Smallest: " + min1 + ", Second Smallest: " + min2);
        }
    }
}
