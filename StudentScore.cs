using System;
class StudentScores
{
    // Method to generate random 2-digit scores for Physics, Chemistry, and Math for all students
    public static int[,] GenerateRandomScores(int numberOfStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numberOfStudents, 3];

        // Generate random scores for each student in PCM
        for (int i = 0; i < numberOfStudents; i++)
        {
            scores[i, 0] = random.Next(50, 101); // Physics score (2-digit)
            scores[i, 1] = random.Next(50, 101); // Chemistry score (2-digit)
            scores[i, 2] = random.Next(50, 101); // Math score (2-digit)
        }

        return scores;
    }

    // Method to calculate the total, average, and percentage for each student
    public static double[,] CalculateScores(int[,] scores, int numberOfStudents)
    {
        double[,] result = new double[numberOfStudents, 3];
        for (int i = 0; i < numberOfStudents; i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2]; // Total score
            double average = total / 3; // Average score
            double percentage = (total / 300) * 100; // Percentage (out of 300)
            // Store the total, average, and percentage for the student
            result[i, 0] = total;
            result[i, 1] = Math.Round(average, 2); // Round off average to 2 digits
            result[i, 2] = Math.Round(percentage, 2); // Round off percentage to 2 digits
        }
        return result;
    }
    // Method to display the scorecard of all students
    public static void DisplayScorecard(int[,] scores, double[,] result, int numberOfStudents)
    {
        Console.WriteLine("Student\tPhysics\t\tChemistry\tMath\t\tTotal\tAverage\tPercentage");
        for (int i = 0; i < numberOfStudents; i++)
        {
            // Display each student's scores, total, average, and percentage
            Console.WriteLine(i + 1 + "\t" + scores[i, 0] + "\t\t" + scores[i, 1] + "\t\t" + scores[i, 2] + "\t\t" 
                + result[i, 0] + "\t" + result[i, 1] + "\t" + result[i, 2] + "%");
        }
    }
    public static void Main(string[] args)
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        // Generate random scores for the students
        int[,] scores = GenerateRandomScores(numberOfStudents);
        // Calculate the total, average, and percentage for each student
        double[,] result = CalculateScores(scores, numberOfStudents);
        // Display the scorecard of all students
        DisplayScorecard(scores, result, numberOfStudents);
    }
}
