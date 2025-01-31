using System;

class Problem_1
{
    public static void Main(string[] args)
    {
        // Get the current time in the local time zone
        DateTime localTime = DateTime.Now;
        Console.WriteLine("Local Time: " + localTime.ToString());

        // Display the current time in GMT (UTC)
        TimeZoneInfo gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTime gmtTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, gmtTimeZone);
        Console.WriteLine("GMT (Greenwich Mean Time): " + gmtTime.ToString());

        // Display the current time in IST (Indian Standard Time)
        TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTime istTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, istTimeZone);
        Console.WriteLine("IST (Indian Standard Time): " + istTime.ToString());

        // Display the current time in PST (Pacific Standard Time)
        TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTime pstTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, pstTimeZone);
        Console.WriteLine("PST (Pacific Standard Time): " + pstTime.ToString());
    }
}