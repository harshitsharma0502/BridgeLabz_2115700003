using System;

class C_To_f_conversion
{
	static void Main()
	{
	Console.Write("Enter the temperature in celsius: ");
	float celsius = Convert.ToSingle(Console.ReadLine());
	
	float fahrenheit = (celsius * (9/5)) + 32;
	
	Console.WriteLine(celsius + " Temperature in fahrenheit is: " + fahrenheit);
	}

}