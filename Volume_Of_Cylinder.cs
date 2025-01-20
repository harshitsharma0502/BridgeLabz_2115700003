using System;

class Volume_Of_Cylinder
{
	static void Main()
	{
		Console.Write("Enter height of cylinder");
		float height = Convert.ToSingle(Console.ReadLine());
		
		Console.Write("Enter radius of cylinder");
		float radius = Convert.ToSingle(Console.ReadLine());
		
		float area = Convert.ToSingle(Math.PI * Math.Pow(radius, 2) * height);
		
		Console.WriteLine("Area of Cylinder is: " + area);
	}
}