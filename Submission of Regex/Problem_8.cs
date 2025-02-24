using System;
using System.Text.RegularExpressions;

class Program
{
    public static string RemoveExtraSpaces(string input)
    {
        return Regex.Replace(input, @"\s+", " ");
    }

    static void Main()
    {
        string input = "This  is   an   example    with    multiple    spaces.";
        string output = RemoveExtraSpaces(input);

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Modified: " + output);
    }
}