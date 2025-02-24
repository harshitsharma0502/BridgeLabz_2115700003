using System;
using System.Text.RegularExpressions;

class Program
{
    public static void ExtractCapitalizedWords(string text)
    {
        string pattern = @"\b[A-Z][a-z]*\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Extracted Capitalized Words:");
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
        else
        {
            Console.WriteLine("No capitalized words found.");
        }
    }

    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        ExtractCapitalizedWords(text);
    }
}