using System;

public class StudentGradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students:");
        int numStudents = int.Parse(Console.ReadLine());

        // Create arrays to store marks, percentages, and grades
        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Input marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.Write("Enter Physics marks for student " + (i + 1) + ": ");
            physicsMarks[i] = int.Parse(Console.ReadLine());
            while (physicsMarks[i] < 0)
            {
                Console.WriteLine("Marks cannot be negative. Please enter valid marks:");
                Console.Write("Enter Physics marks for student " + (i + 1) + ": ");
                physicsMarks[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter Chemistry marks for student " + (i + 1) + ": ");
            chemistryMarks[i] = int.Parse(Console.ReadLine());
            while (chemistryMarks[i] < 0)
            {
                Console.WriteLine("Marks cannot be negative. Please enter valid marks:");
                Console.Write("Enter Chemistry marks for student " + (i + 1) + ": ");
                chemistryMarks[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter Maths marks for student " + (i + 1) + ": ");
            mathsMarks[i] = int.Parse(Console.ReadLine());
            while (mathsMarks[i] < 0)
            {
                Console.WriteLine("Marks cannot be negative. Please enter valid marks:");
                Console.Write("Enter Maths marks for student " + (i + 1) + ": ");
                mathsMarks[i] = int.Parse(Console.ReadLine());
            }

            // Calculate percentage
            percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 300.0 * 100;

            // Determine grade based on percentage
            if (percentages[i] >= 80)
            {
                grades[i] = "A";
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = "B";
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = "C";
            }
            else if (percentages[i] >= 50)
            {
                grades[i] = "D";
            }
            else if (percentages[i] >= 40)
            {
                grades[i] = "E";
            }
            else
            {
                grades[i] = "R";
            }
        }

        // Display results
        Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine((i + 1) + "\t" + physicsMarks[i] + "\t\t" + chemistryMarks[i] + "\t\t" + mathsMarks[i] + "\t\t" + percentages[i].ToString("F2") + "\t\t" + grades[i]);
        }
    }
}
