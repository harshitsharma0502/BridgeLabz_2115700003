using System;

namespace GCDAndLCMCalculator
{
    class GCDandLCM
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("GCD and LCM Calculator");
            int num1 = GetIntegerInput("Enter the first positive integer: ");
            int num2 = GetIntegerInput("Enter the second positive integer: ");

            int gcd = CalculateGCD(num1, num2);
            int lcm = CalculateLCM(num1, num2, gcd);

            Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcd);
            Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcm);
        }

        static int GetIntegerInput(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    continue;
                }

                bool isValid = true;
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("Invalid input. Please enter a positive integer.");
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
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive integer.");
                    }
                }
            }
        }

        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int CalculateLCM(int a, int b, int gcd)
        {
            return (a / gcd) * b;
        }
    }
}