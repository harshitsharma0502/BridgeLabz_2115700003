using System;

class Simple_Interest
{
	static void Main()
	{
		Console.Write("Enter principal amount: ");
		float principal = Convert.ToSingle(Console.ReadLine());
		
		
		Console.Write("Enter Time in year: ");
		float time = Convert.ToSingle(Console.ReadLine());
		
		Console.Write("Enter Rate amount: ");
		float rate = Convert.ToSingle(Console.ReadLine());
		
		float Simple_Interest = (principal * rate * time) / 100;
		
		Console.WriteLine("Simple Interest is: " + Simple_Interest);
		
		
	}
}