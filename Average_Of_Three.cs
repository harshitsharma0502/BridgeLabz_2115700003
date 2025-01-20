using System;

class Average_Of_Three
{
	static void Main()
	{
		Console.Write("Enter three numbers");
		float num1 = Convert.ToSingle(Console.ReadLine());
		float num2 = Convert.ToSingle(Console.ReadLine());
		float num3 = Convert.ToSingle(Console.ReadLine());
		
		float Average = (num1 + num2 + num3) / 3;
		
		Console.WriteLine(string.Format("Average of {0}, {1}, {2} is {3}",num1,num2,num3,Average));
	}
}