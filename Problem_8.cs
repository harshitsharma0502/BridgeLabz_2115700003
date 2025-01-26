using System;

public class FriendInfo
{
    public static void Main(string[] args)
    {
        // Input for age
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());

        // Input for height
        Console.Write("Enter Amar's height (in cm): ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar's height (in cm): ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony's height (in cm): ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());

        // Find the youngest friend
        int youngestAge = Math.Min(Math.Min(amarAge, akbarAge), anthonyAge);
        if (youngestAge == amarAge)
            Console.WriteLine("Amar is the youngest with age " + amarAge + ".");
        else if (youngestAge == akbarAge)
            Console.WriteLine("Akbar is the youngest with age " + akbarAge + ".");
        else
            Console.WriteLine("Anthony is the youngest with age " + anthonyAge + ".");

        // Find the tallest friend
        int tallestHeight = Math.Max(Math.Max(amarHeight, akbarHeight), anthonyHeight);
        if (tallestHeight == amarHeight)
            Console.WriteLine("Amar is the tallest with height " + amarHeight + " cm.");
        else if (tallestHeight == akbarHeight)
            Console.WriteLine("Akbar is the tallest with height " + akbarHeight + " cm.");
        else
            Console.WriteLine("Anthony is the tallest with height " + anthonyHeight + " cm.");
    }
}