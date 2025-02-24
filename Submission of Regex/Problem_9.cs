using System;
using System.Text.RegularExpressions;

class Program
{
    public static string CensorBadWords(string input, string[] badWords)
    {
        foreach (string word in badWords)
        {
            input = Regex.Replace(input, $@"\b{word}\b", "****", RegexOptions.IgnoreCase);
        }
        return input;
    }

    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" };

        string output = CensorBadWords(input, badWords);

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Censored: " + output);
    }
}