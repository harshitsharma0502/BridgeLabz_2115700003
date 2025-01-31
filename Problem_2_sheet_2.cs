using System;

namespace MaxOfThreeNumbers
{
    class Maximum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers:");

            // Take three integer inputs from the user
            int num1 = GetIntegerInput("Enter the first number: ");
            int num2 = GetIntegerInput("Enter the second number: ");
            int num3 = GetIntegerInput("Enter the third number: ");

            // Calculate the maximum of the three numbers
            int max = FindMaximum(num1, num2, num3);

            // Display the result
            Console.WriteLine("The maximum number is: " + max);
        }

        static int GetIntegerInput(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        static int FindMaximum(int a, int b, int c)
        {
            int max = a; // Assume the first number is the maximum

            if (b > max)
            {
                max = b; // Update max if the second number is greater
            }

            if (c > max)
            {
                max = c; // Update max if the third number is greater
            }

            return max;
        }
    }
}