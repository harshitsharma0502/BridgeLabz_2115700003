using System;
using System.Text.RegularExpressions;

class Program
{
    public static void ExtractEmails(string text)
    {
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection matches = Regex.Matches(text, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Extracted Email Addresses:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No email addresses found.");
        }
    }

    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org. You can also reach admin@website.net!";
        ExtractEmails(text);
    }
}