using System;

class NumberChecker
{
    public static void Main(string[] args) // Ensure this signature is compatible
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = GetDigitCount(number);
        int[] digits = GetDigits(number, digitCount);

        Console.WriteLine("Number of digits: " + digitCount);
        Console.Write("Digits array: ");
        PrintArray(digits);

        int[] reversedDigits = ReverseArray(digits);
        Console.Write("Reversed digits array: ");
        PrintArray(reversedDigits);

        Console.WriteLine("Arrays are equal: " + CompareArrays(digits, reversedDigits));
        Console.WriteLine("Is Palindrome Number: " + IsPalindrome(digits));
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
    }

    public static int GetDigitCount(int number)
    {
        int count = 0;
        while (number > 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    public static int[] GetDigits(int number, int digitCount)
    {
        int[] digits = new int[digitCount];
        int index = digitCount - 1;

        while (number > 0)
        {
            digits[index--] = number % 10;
            number /= 10;
        }

        return digits;
    }

    public static int[] ReverseArray(int[] digits)
    {
        int length = digits.Length;
        int[] reversed = new int[length];

        for (int i = 0; i < length; i++)
        {
            reversed[i] = digits[length - i - 1];
        }

        return reversed;
    }

    public static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsPalindrome(int[] digits)
    {
        int[] reversed = ReverseArray(digits);
        return CompareArrays(digits, reversed);
    }

    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 1; i < digits.Length; i++)
        {
            if (digits[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
