using System;
class SmallestNo{
	public static void Main(string[] args){
		Console.WriteLine("Enter three numbers: ");
		int num1=int.Parse(Console.ReadLine());
		int num2=int.Parse(Console.ReadLine());
		int num3=int.Parse(Console.ReadLine());
		String ans1=(num1>num2&&num1>num3)?"yes":"no";
		String ans2=(num2>num1&&num2>num3)?"yes":"no";
		String ans3=(num3>num2&&num3>num1)?"yes":"no";
		Console.WriteLine("Is the first number the largest? "+ans1);
		Console.WriteLine("Is the second number the largest? "+ans2);
		Console.WriteLine("Is the third number the largest? "+ans3);
	}
}
			