using System;

namespace FibonacciSequenceGenerator
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms for the Fibonacci sequence:");
            int numberOfTerms = GetIntegerInput("Enter a positive integer: ");

            if (numberOfTerms <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
            }
            else
            {
                Console.WriteLine("Fibonacci sequence up to " + numberOfTerms + " terms:");
                PrintFibonacciSequence(numberOfTerms);
            }
        }

        static int GetIntegerInput(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        static void PrintFibonacciSequence(int numberOfTerms)
        {
            int firstTerm = 0;
            int secondTerm = 1;
            int nextTerm;

            for (int i = 1; i <= numberOfTerms; i++)
            {
                Console.Write(firstTerm + " ");

                nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}