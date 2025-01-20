using System;

class Kilometer_To_Miles
{
	static void Main()
	{
		Console.Write("Enter Kilometer: ");
		float kilometer = Convert.ToSingle(Console.ReadLine());
		
		float miles = Convert.ToSingle(kilometer * 0.621371);
		
		Console.WriteLine(kilometer + " Kilometer is equal to " + miles + " Miles");
	}

}