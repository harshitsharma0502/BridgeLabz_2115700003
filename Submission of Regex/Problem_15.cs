using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        return Regex.IsMatch(ssn, pattern);
    }

    static void Main()
    {
        string[] testSSNs = { "123-45-6789", "123456789", "987-65-4321", "12-345-6789" };

        foreach (string ssn in testSSNs)
        {
            if (IsValidSSN(ssn))
                Console.WriteLine($" \"{ssn}\" is valid");
            else
                Console.WriteLine($" \"{ssn}\" is invalid");
        }
    }
}