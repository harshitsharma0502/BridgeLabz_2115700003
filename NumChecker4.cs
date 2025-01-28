using System;

class NumberChecker
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Is Prime Number: " + IsPrime(number));
        Console.WriteLine("Is Neon Number: " + IsNeonNumber(number));
        Console.WriteLine("Is Spy Number: " + IsSpyNumber(number));
        Console.WriteLine("Is Automorphic Number: " + IsAutomorphic(number));
        Console.WriteLine("Is Buzz Number: " + IsBuzzNumber(number));
    }
    public static bool IsPrime(int number) // Method to check if a number is a prime number
    {
        if (number <= 1) return false;
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    public static bool IsNeonNumber(int number) // Method to check if a number is a neon number
    {
        int square = number * number;
        int sumOfDigits = 0;

        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }

        return sumOfDigits == number;
    }
    public static bool IsSpyNumber(int number) // Method to check if a number is a spy number
    {
        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }

        return sum == product;
    }
    public static bool IsAutomorphic(int number) // d. Method to check if a number is an automorphic number
    {
        int square = number * number;
        int temp = number;

        while (temp > 0)
        {
            if (square % 10 != temp % 10)
                return false;
            square /= 10;
            temp /= 10;
        }

        return true;
    }
    public static bool IsBuzzNumber(int number) // Method to check if a number is a buzz number
    {
        return number % 7 == 0 || number % 10 == 7;
    }
}
