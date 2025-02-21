using System;
using System.IO;

class StudentData
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\student_data.bin";

        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(101);
            writer.Write("John Doe");
            writer.Write(3.85);
        }

        Console.WriteLine("Student data has been stored successfully.");

        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int rollNumber = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine("Retrieved Student Details:");
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"GPA: {gpa}");
        }
    }
}
