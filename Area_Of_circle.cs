using System;

class Area_Of_circle
{
	static void Main()
	{
	Console.Write("Enter the radius of the circle: ");
	double Radius = Convert.ToDouble(Console.ReadLine());
	
	double area = Math.PI * Math.Pow(Radius, 2);

	Console.WriteLine("Area of circle is: " + area);	
	}
}