using System;

public class Course
{
    // Instance variables
    public string CourseName;
    public int Duration; // Duration in weeks
    public decimal Fee;

    // Class variable
    public static string InstituteName;

    // Constructor
    public Course(string courseName, int duration, decimal fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Institute Name: {InstituteName}");
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Duration: {Duration} weeks");
        Console.WriteLine($"Fee: {Fee:C}");
    }

    // Class method to update institute name
    public static void UpdateInstituteName(string newInstituteName)
    {
        InstituteName = newInstituteName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Set the initial institute name
        Course.UpdateInstituteName("Global Education Institute");

        // Create courses
        Course course1 = new Course("Software Development", 12, 1500.00m);
        Course course2 = new Course("Data Science", 16, 2000.00m);
        Course course3 = new Course("Digital Marketing", 8, 1200.00m);

        // Display course details
        Console.WriteLine("Course 1 Details:");
        course1.DisplayCourseDetails();

        Console.WriteLine("\nCourse 2 Details:");
        course2.DisplayCourseDetails();

        Console.WriteLine("\nCourse 3 Details:");
        course3.DisplayCourseDetails();

        // Update institute name
        Console.WriteLine("\nUpdating Institute Name...\n");
        Course.UpdateInstituteName("Tech Academy");

        // Display updated course details
        Console.WriteLine("Updated Course 1 Details:");
        course1.DisplayCourseDetails();

        Console.WriteLine("\nUpdated Course 2 Details:");
        course2.DisplayCourseDetails();

        Console.WriteLine("\nUpdated Course 3 Details:");
        course3.DisplayCourseDetails();
    }
}