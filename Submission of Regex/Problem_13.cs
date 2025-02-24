using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    public static List<string> ExtractCurrencyValues(string text)
    {
        List<string> currencyValues = new List<string>();

        string pattern = @"\$\s?\d+\.\d{2}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            currencyValues.Add(match.Value);
        }

        return currencyValues;
    }

    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";

        List<string> valuesFound = ExtractCurrencyValues(text);

        Console.WriteLine(string.Join(", ", valuesFound));
    }
}