using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    public static List<string> FindRepeatingWords(string text)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        List<string> repeatingWords = new List<string>();

        string pattern = @"\b\w+\b";
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            string word = match.Value.ToLower();

            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        foreach (var entry in wordCount)
        {
            if (entry.Value > 1)
            {
                repeatingWords.Add(entry.Key);
            }
        }

        return repeatingWords;
    }

    static void Main()
    {
        string text = "This is is a repeated repeated word test.";

        List<string> repeatedWords = FindRepeatingWords(text);

        Console.WriteLine(string.Join(", ", repeatedWords));
    }
}