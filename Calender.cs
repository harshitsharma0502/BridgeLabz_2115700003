using System;

class CalendarDisplay
{
    static void Main()
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());  

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine()); 
        DisplayCalendar(month, year);  // Displaying the calendar for the given month and year
    }
    public static string GetMonthName(int month)    // Method to get the name of the month

    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        return months[month - 1];  
    }

    public static int GetDaysInMonth(int month, int year) // Method to get the number of days in the month
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; 

        if (month == 2 && IsLeapYear(year))  // If the month is February and the year is a leap year
        {
            return 29;  // Return 29 days for February in a leap year
        }

        return daysInMonth[month - 1];  
    }
    public static bool IsLeapYear(int year) // Method to check if a year is a leap year
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);  // Leap year rule check
    }
    public static int GetFirstDayOfMonth(int month, int year) // Method to get the first day of the month (using the Gregorian calendar algorithm)
    {
        int y0 = year - (14 - month) / 12;  
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;  
        int m0 = month + 12 * ((14 - month) / 12) - 2; 
        int d0 = (1 + x + 31 * m0 / 12) % 7; 
        return d0;  
    }
    public static void DisplayCalendar(int month, int year) // Method to display the calendar for a given month and year
    {
        string monthName = GetMonthName(month); 
        int daysInMonth = GetDaysInMonth(month, year);  
        int firstDay = GetFirstDayOfMonth(month, year); 
        Console.WriteLine(monthName + " " + year);  // Display month and year without using string interpolation
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");  // Days of the week header
        
        for (int i = 0; i < firstDay; i++)  
        {
            Console.Write("    ");  // Four spaces for alignment
        }

        
        for (int day = 1; day <= daysInMonth; day++)  // Print the days of the month
        {
            Console.Write("{0,3} ", day);  // Right-justified with width of 3 (using formatting)
            if ((firstDay + day) % 7 == 0)  // Move to the next line after Saturday (7th day)
            {
                Console.WriteLine();  // New line for the next week
            }
        }
        Console.WriteLine();  // To ensure the calendar output ends properly
    }
}
