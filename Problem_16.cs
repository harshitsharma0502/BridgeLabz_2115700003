using System;

class OddEvenNumbers
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
		int number = int.Parse(Console.ReadLine());
		if (number < 1)
		{
			Console.WriteLine("Please enter a natural number (greater than 0).");
		}
		else
		{
			for (int i = 1; i <= number; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine("{0} is an even number.", i);
				}
				else
				{
					Console.WriteLine("{0} is an odd number.", i);
				}
			}
		}
    }
}
