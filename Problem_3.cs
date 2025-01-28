using System;

class GradeCalculator
{
    public static void Main(string[] args)
    {
        // Input marks
        Console.Write("Enter Physics marks: ");
        double physics = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        double chemistry = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        double maths = Convert.ToDouble(Console.ReadLine());

        // Calculate total, average, and percentage
        double totalMarks = physics + chemistry + maths;
        double averageMarks = totalMarks / 3;
        double percentage = (totalMarks / 300) * 100;

        // Display results
        Console.WriteLine("Average Marks: " + averageMarks.ToString("F2"));
        Console.WriteLine("Percentage: " + percentage.ToString("F2") + "%");

        // Determine grade
        string grade;
        if (averageMarks >= 80)
        {
            grade = "A";
        }
        else if (averageMarks >= 70)
        {
            grade = "B";
        }
        else if (averageMarks >= 60)
        {
            grade = "C";
        }
        else if (averageMarks >= 50)
        {
            grade = "D";
        }
        else if (averageMarks >= 40)
        {
            grade = "E";
        }
        else
        {
            grade = "R";
        }

        Console.WriteLine("Grade: " + grade);
    }
}