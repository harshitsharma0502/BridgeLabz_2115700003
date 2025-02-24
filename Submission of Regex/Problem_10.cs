using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidIPv4(string ipAddress)
    {
        string pattern = @"^(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)$";

        return Regex.IsMatch(ipAddress, pattern);
    }

    static void Main()
    {
        string[] testIPs = { "192.168.1.1", "255.255.255.255", "300.168.0.1", "1.1.1", "10.0.0.256", "0.0.0.0" };

        foreach (string ip in testIPs)
        {
            Console.WriteLine($"{ip} : {(IsValidIPv4(ip) ? "Valid" : "Invalid")}");
        }
    }
}