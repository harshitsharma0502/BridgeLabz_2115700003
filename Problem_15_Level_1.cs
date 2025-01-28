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
			for (int i = 1; i <= num; i++)
			{
				factorial *= i;
			}
			Console.WriteLine("The factorial of {0} is {1}.", num, factorial);
		}
    }
}
