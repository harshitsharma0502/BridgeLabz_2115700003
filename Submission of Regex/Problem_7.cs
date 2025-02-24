using System;
using System.Text.RegularExpressions;

class Program
{
    public static void ExtractLinks(string text)
    {

        string pattern = @"\bhttps?://[^\s]+";

        MatchCollection matches = Regex.Matches(text, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Extracted Links:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No links found.");
        }
    }

    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        ExtractLinks(text);
    }
}