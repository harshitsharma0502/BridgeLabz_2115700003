using System;

public class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }

    public void SetCGPA(double cgpa)
    {
        if (cgpa >= 0 && cgpa <= 10)
        {
            CGPA = cgpa;
        }
        else
        {
            Console.WriteLine("Invalid CGPA value.");
        }
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"CGPA: {CGPA:F2}");
    }
}

public class PostgraduateStudent : Student
{
    public string ResearchTopic;

    public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
        : base(rollNumber, name, cgpa)
    {
        ResearchTopic = researchTopic;
    }

    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Research Topic: {ResearchTopic}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(101, "Alice", 8.5);
        student.DisplayStudentDetails();
        student.SetCGPA(9.2);
        Console.WriteLine($"Updated CGPA: {student.GetCGPA():F2}");

        PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Bob", 9.0, "Artificial Intelligence");
        pgStudent.DisplayPostgraduateDetails();
    }
}