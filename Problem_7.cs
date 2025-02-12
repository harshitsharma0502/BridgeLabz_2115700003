using System;

public class Course
{
   public string CourseName { get; set; }
   public int Duration { get; set; }
   public Course(string courseName, int duration)
   {
       CourseName = courseName;
       Duration = duration;
   }
   public virtual void DisplayCourseDetails()
   {
       Console.WriteLine($"Course Name: {CourseName}, Duration: {Duration} hours");
   }
}
public class OnlineCourse : Course
{
   public string Platform { get; set; }
   public bool IsRecorded { get; set; }

   public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
       : base(courseName, duration)
   {
       Platform = platform;
       IsRecorded = isRecorded;
   }

   public override void DisplayCourseDetails()
   {
       base.DisplayCourseDetails();
       Console.WriteLine($"Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}");
   }
}
public class PaidOnlineCourse : OnlineCourse
{
   public double Fee { get; set; }
   public double Discount { get; set; } 

   public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
       : base(courseName, duration, platform, isRecorded)
   {
       Fee = fee;
       Discount = discount;
   }

   public double CalculateFinalFee()
   {
       return Fee - (Fee * Discount / 100);
   }

   public override void DisplayCourseDetails()
   {
       base.DisplayCourseDetails();
       Console.WriteLine($"Fee: ${Fee}, Discount: {Discount}%, Final Fee: ${CalculateFinalFee()}");
   }
}
class Program
{
   static void Main(string[] args)
   {
       Course course = new Course("Introduction to Programming", 40);
       course.DisplayCourseDetails();

       OnlineCourse onlineCourse = new OnlineCourse("Web Development Bootcamp", 60, "Udemy", true);
       onlineCourse.DisplayCourseDetails();

       PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Advanced Data Science", 80, "Coursera", true, 499.99, 20);
       paidOnlineCourse.DisplayCourseDetails();
   }
}