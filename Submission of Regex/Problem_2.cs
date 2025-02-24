using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidLicensePlate(string plate)
    {
        // ^[A-Z]{2}   → Must start with exactly two uppercase letters
        // \d{4}$      → Must be followed by exactly four digits (0-9)
        string pattern = @"^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }

    static void Main()
    {
        string[] testPlates = { "AB1234", "A12345", "XY6789", "ab1234", "1234AB", "ZZ999" };

        foreach (string plate in testPlates)
        {
            Console.WriteLine($"'{plate}'  {(IsValidLicensePlate(plate) ? "Valid" : "Invalid")}");
        }
    }
}