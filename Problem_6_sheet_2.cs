using System;

namespace FactorialCalculator
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Factorial Calculator");
            int number = GetIntegerInput("Enter a non-negative integer: ");
            long factorial = CalculateFactorial(number);
            DisplayResult(number, factorial);
        }

        static int GetIntegerInput(string prompt)
        {
            int number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                    continue;
                }

                isValid = true;
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    number = 0;
                    foreach (char c in input)
                    {
                        number = number * 10 + (c - '0');
                    }
                }
            }

            return number;
        }

        static long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }

        static void DisplayResult(int number, long factorial)
        {
            Console.Write("The factorial of ");
            Console.Write(number);
            Console.Write(" is ");
            Console.WriteLine(factorial);
        }
    }
}