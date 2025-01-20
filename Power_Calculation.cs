using System;

class Power_Calculation
{
	static void Main()
	{
	Console.Write("Enter Base number");
	double Base = Convert.ToDouble(Console.ReadLine());
	
	Console.Write("Enter Exponent number");
	double exponent = Convert.ToDouble(Console.ReadLine());
	
	double result = Math.Pow(Base, exponent);
	
	Console.WriteLine(Base + " raised to the power " + exponent + " is = " + result);
	}
}