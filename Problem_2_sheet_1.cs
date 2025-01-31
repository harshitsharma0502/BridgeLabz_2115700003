using System;
class DataArithmetic{
    public static void Main(string[] args)
    {
        // Prompt the user to enter a date
        Console.WriteLine("Enter a date (format: MM/dd/yyyy): ");
        string inputDate = Console.ReadLine();

        // Parse the input date
        DateTime date = DateTime.Parse(inputDate);

        // Add 7 days
        date = date.AddDays(7);
        Console.WriteLine("Date after adding 7 days: " + date.ToString());

        // Add 1 month
        date = date.AddMonths(1);
        Console.WriteLine("Date after adding 1 month: " + date.ToString());

        // Add 2 years
        date = date.AddYears(2);
        Console.WriteLine("Date after adding 2 years: " + date.ToString());

        // Subtract 3 weeks (3 weeks = 21 days)
        date = date.AddDays(-21);
        Console.WriteLine("Date after subtracting 3 weeks: " + date.ToString());
    }
}