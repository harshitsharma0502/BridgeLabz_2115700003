using System;
namespace DataComparison
{	
	class DataComparison
	{
		public static void Main(string[] args)
		{
			// Prompt the user to enter the first date
			Console.WriteLine("Enter the first date (format: MM/dd/yyyy): ");
			string inputDate1 = Console.ReadLine();

			// Prompt the user to enter the second date
			Console.WriteLine("Enter the second date (format: MM/dd/yyyy): ");
			string inputDate2 = Console.ReadLine();

			// Parse the input dates
			DateTime date1 = DateTime.Parse(inputDate1);
			DateTime date2 = DateTime.Parse(inputDate2);

			// Compare the dates
			int comparisonResult = DateTime.Compare(date1, date2);

			if (comparisonResult < 0)
			{
				Console.WriteLine("The first date is before the second date.");
			}
			else if (comparisonResult > 0)
			{
				Console.WriteLine("The first date is after the second date.");
			}
			else
			{
				Console.WriteLine("The first date is the same as the second date.");
			}
		}
	}
}