using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidHexColor(string color)
    {
        // ^# → Must start with #
        // [0-9A-Fa-f]{6} → Followed by exactly six hex characters (0-9, A-F, a-f)
        string pattern = @"^#[0-9A-Fa-f]{6}$";
        return Regex.IsMatch(color, pattern);
    }

    static void Main()
    {
        string[] testColors = { "#FFA500", "#ff4500", "#123", "#GGG123", "FFA500", "#12345G" };

        foreach (string color in testColors)
        {
            Console.WriteLine($"'{color}'  {(IsValidHexColor(color) ? "Valid" : "Invalid")}");
        }
    }
}