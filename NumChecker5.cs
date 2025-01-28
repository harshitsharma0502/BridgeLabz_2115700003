using System;

class NumberChecker
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);
        Console.Write("Factors: ");
        PrintArray(factors);

        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + FindSumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + FindProductOfFactors(factors));
        Console.WriteLine("Product of Cubes of Factors: " + FindProductOfCubeOfFactors(factors));
        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number));
        Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number));
        Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number));
        Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
    }
    public static int[] FindFactors(int number)  // Method to find factors of a number and return them as an array
    {
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++) // Store the factors in the array
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }
    public static int FindGreatestFactor(int[] factors) // Method to find the greatest factor of a number
    {
        int greatest = factors[0];

        foreach (int factor in factors)
        {
            if (factor > greatest)
            {
                greatest = factor;
            }
        }

        return greatest;
    }
    public static int FindSumOfFactors(int[] factors) // Method to find the sum of factors
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }
    public static int FindProductOfFactors(int[] factors) // Method to find the product of factors
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }
    public static double FindProductOfCubeOfFactors(int[] factors) // Method to find product of cubes of factors
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }
    public static bool IsPerfectNumber(int number) // Method to check if a number is a perfect number
    {
        int sumOfProperDivisors = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfProperDivisors += i;
            }
        }

        return sumOfProperDivisors == number;
    }
    public static bool IsAbundantNumber(int number) // Method to check if a number is an abundant number
    {
        int sumOfProperDivisors = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfProperDivisors += i;
            }
        }

        return sumOfProperDivisors > number;
    }
    public static bool IsDeficientNumber(int number) // Method to check if a number is a deficient number
    {
        int sumOfProperDivisors = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfProperDivisors += i;
            }
        }

        return sumOfProperDivisors < number;
    }
    public static bool IsStrongNumber(int number) // Method to check if a number is a strong number
    {
        int sumOfFactorials = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);
            temp /= 10;
        }

        return sumOfFactorials == number;
    }
    public static int Factorial(int n) // Helper method to compute the factorial of a digit
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    public static void PrintArray(int[] array) // Helper method to print an array
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
