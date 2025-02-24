using System;
using System.Text.RegularExpressions;

class Program
{
    public static void ExtractDates(string text)
    {
        string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/[0-9]{4}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Extracted Dates:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No dates found.");
        }
    }

    static void Main()
    {
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        ExtractDates(text);
    }
}