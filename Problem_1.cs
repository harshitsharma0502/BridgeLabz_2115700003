using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter the first number: ");
        int dividend = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int divisor = int.Parse(Console.ReadLine());

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        Console.WriteLine("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}", quotient, remainder,dividend,divisor);
    }
}
