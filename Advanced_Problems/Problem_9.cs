using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\Students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                string[] values = line.Split(',');

                if (values.Length == 4 &&
                    int.TryParse(values[0], out int id) &&
                    int.TryParse(values[2], out int age) &&
                    int.TryParse(values[3], out int marks))
                {
                    Student student = new Student
                    {
                        ID = id,
                        Name = values[1].Trim(),
                        Age = age,
                        Marks = marks
                    };

                    students.Add(student);
                }
            }
        }

        Console.WriteLine("Students List:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
