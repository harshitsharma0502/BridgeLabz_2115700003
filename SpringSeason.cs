using System;

class SpringSeason
{
    // Method to check if the given date falls in the spring season
    public bool Season(int month, int day)
    {
        // Spring season is from March 20 (3/20) to June 20 (6/20)
        if ((month == 3 && day >= 20) ||   // From March 20 onward
            (month > 3 && month < 6) ||   // Entire months of April and May
            (month == 6 && day <= 20))    // Up to June 20
        {
            return true; // It's spring season
        }
        else
        {
            return false; // Not spring season
        }
    }

    public static void Main(string[] args)
    {
        // Prompt the user to enter the month
        Console.WriteLine("Enter the month (1-12):");
        int month = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the day
        Console.WriteLine("Enter the day (1-31):");
        int day = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the SpringSeason class
        SpringSeason check = new SpringSeason();

        // Check if the entered date is in the spring season
        bool result = check.Season(month, day);

        // Output the result
        if (result)
            Console.WriteLine("It's a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }
}
