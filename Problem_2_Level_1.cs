using System;
class SmallestNo{
	public static void Main(string[] args){
		Console.WriteLine("Enter three numbers: ");
		int num1=int.Parse(Console.ReadLine());
		int num2=int.Parse(Console.ReadLine());
		int num3=int.Parse(Console.ReadLine());
		String ans="yes";
		if(num1>=num2||num1>=num3){
			ans="no";
		}
		Console.WriteLine("Is the first number the Smallest? "+ans);
	}
}
			