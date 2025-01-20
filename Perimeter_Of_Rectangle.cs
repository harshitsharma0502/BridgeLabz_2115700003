using System;

class Perimeter_Of_Rectangle
{
	static void Main()
	{
		Console.Write("Enter length of rectangle: ");
		float length  = Convert.ToSingle(Console.ReadLine());
		
		Console.Write("Enter width of rectangle: ");
		float width  = Convert.ToSingle(Console.ReadLine());
		
		float perimeter = 2 * (length + width);
		
		Console.WriteLine("Perimeter Of Rectangle is: " + perimeter);
	}
}