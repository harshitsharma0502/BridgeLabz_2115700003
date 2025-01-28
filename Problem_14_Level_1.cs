using System;

class Factorial
{
    public static void Main(string[] args)
    {
		Console.Write("Enter a positive integer: ");
		int num = int.Parse(Console.ReadLine());

		if (num < 0)
		{
			Console.WriteLine("Please enter a valid positive integer.");
		}
		else
		{
			int factorial = 1;
			int i = 1;
			while (i <= num)
			{
				factorial *= i;
				i++;
			}
			Console.WriteLine("The factorial of {0} is {1}.", num, factorial);
		}
    }
}
