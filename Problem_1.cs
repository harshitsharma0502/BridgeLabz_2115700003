using System;
class CheckNumber{
	public static void Main(string[] args){
		Console.WriteLine("Enter your number: ");
		int num=int.Parse(Console.ReadLine());
		String IsNum="no";
		if(num%5==0){
			IsNum="yes";
		}
		Console.WriteLine("Is the number "+num+" divisible by 5? "+IsNum);
	}
}