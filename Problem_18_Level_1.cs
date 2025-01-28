using System;

class MultiplicationTable
{
    public static void Main(string[] args)
    {
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		for (int i = 6; i <= 9; i++)
		{
			Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
		}
    }
}
