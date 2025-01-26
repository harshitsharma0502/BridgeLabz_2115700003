using System;

public class StudentGradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students:");
        int numStudents = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks (rows for students, columns for subjects)
        int[,] marks = new int[numStudents, 3]; // 3 subjects (Physics, Chemistry, Maths)
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Input marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.Write("Enter Physics marks for student " + (i + 1) + ": ");
            marks[i, 0] = int.Parse(Console.ReadLine());
            while (marks[i, 0] < 0)
            {
                Console.WriteLine("Marks cannot be negative. Please enter valid marks:");
                Console.Write("Enter Physics marks for student " + (i + 1) + ": ");
                marks[i, 0] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter Chemistry marks for student " + (i + 1) + ": ");
            marks[i, 1] = int.Parse(Console.ReadLine());
            while (marks[i, 1] < 0)
            {
                Console.WriteLine("Marks cannot be negative. Please enter valid marks:");
                Console.Write("Enter Chemistry marks for student " + (i + 1) + ": ");
                marks[i, 1] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter Maths marks for student " + (i + 1) + ": ");
            marks[i, 2] = int.Parse(Console.ReadLine());
            while (marks[i, 2] < 0)
            {
                Console.WriteLine("Marks cannot be negative. Please enter valid marks:");
                Console.Write("Enter Maths marks for student " + (i + 1) + ": ");
                marks[i, 2] = int.Parse(Console.ReadLine());
            }

            // Calculate percentage
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 300.0 * 100;

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
            Console.WriteLine((i + 1) + "\t" + marks[i, 0] + "\t\t" + marks[i, 1] + "\t\t" + marks[i, 2] + "\t\t" + percentages[i].ToString("F2") + "\t\t" + grades[i]);
        }
    }
}
