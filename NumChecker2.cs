using System;

class NumberChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitCount = GetDigitCount(number);
        int[] digits = GetDigits(number, digitCount);

        Console.WriteLine("Number of digits: " + digitCount);
        Console.Write("Digits array: ");
        for (int i = 0; i < digitCount; i++) Console.Write(digits[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Sum of digits: " + GetSumOfDigits(digits));
        Console.WriteLine("Sum of squares of digits: " + GetSumOfSquaresOfDigits(digits));
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));

        int[,] frequency = GetDigitFrequency(digits);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine("Digit: " + frequency[i, 0] + ", Frequency: " + frequency[i, 1]);
            }
        }
    }
    public static int GetDigitCount(int number)
    {
        int count = 0;
        int temp = number;

        while (temp > 0)
        {
            temp /= 10;
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

    public static int GetSumOfDigits(int[] digits)     // Method to find the sum of the digits of a number

    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        return sum;
    }

    public static int GetSumOfSquaresOfDigits(int[] digits) // Method to find the sum of the squares of the digits of a number
    {
        int sumOfSquares = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sumOfSquares += (int)Math.Pow(digits[i], 2);
        }
        return sumOfSquares;
    }

    public static bool IsHarshadNumber(int number, int[] digits) // Method to check if a number is a Harshad number
    {
        int sumOfDigits = GetSumOfDigits(digits);
        return number % sumOfDigits == 0;
    }

    public static int[,] GetDigitFrequency(int[] digits) // Method to find the frequency of each digit in the number
    {
        int[,] frequencyTable = new int[10, 2];

        for (int i = 0; i < 10; i++)  // Initialize frequency table with digits from 0 to 9
        {
            frequencyTable[i, 0] = i; // Digit value
            frequencyTable[i, 1] = 0; // Initial frequency
        }

        for (int i = 0; i < digits.Length; i++)
        {
            frequencyTable[digits[i], 1]++;
        }

        return frequencyTable;
    }
}
