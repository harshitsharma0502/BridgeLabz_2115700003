using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    public static List<string> ExtractProgrammingLanguages(string text)
    {

        string[] languages = { "Java", "Python", "JavaScript", "C#", "C++", "Go", "Ruby", "Swift", "Kotlin", "PHP", "TypeScript", "Rust", "Perl" };

        List<string> foundLanguages = new List<string>();

        foreach (string language in languages)
        {
            string pattern = $@"\b{language}\b";
            if (Regex.IsMatch(text, pattern))
            {
                foundLanguages.Add(language);
            }
        }

        return foundLanguages;
    }

    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

        List<string> languagesFound = ExtractProgrammingLanguages(text);

        Console.WriteLine(string.Join(", ", languagesFound));
    }
}