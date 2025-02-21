using System;
class DivisionHandler{
	static void Main(){
		try{
			Console.WriteLine("Enter numerator: ");
			int a=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter denominator: ");
			int b=int.Parse(Console.ReadLine());
			
			int result=a/b;
			Console.WriteLine("Result: "+ result);
		}
		catch(DivideByZeroException){
			Console.WriteLine("Wrong input : Entered 0 as an input.");
		}
		catch(FormatException){
			Console.WriteLine("Wrong input : Entered non-numeric value as an input.");
		}
		catch(Exception ex){
			Console.WriteLine("Some error occured:" + ex.Message);
		}
	}
}