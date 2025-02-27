using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }

    public override string ToString()
    {
        return $"{ID},{Name},{Age},{Marks},{Grade}";
    }
}

class Program
{
    static void Main()
    {
        string file1 = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\Students1.csv";
        string file2 = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\Students2.csv";
        string outputFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\merged_students.csv";

        if (!File.Exists(file1) || !File.Exists(file2))
        {
            Console.WriteLine("One or both CSV files not found!");
            return;
        }

        Dictionary<int, Student> studentData = new Dictionary<int, Student>();

        using (StreamReader reader = new StreamReader(file1))
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
                if (values.Length == 3 && int.TryParse(values[0], out int id) && int.TryParse(values[2], out int age))
                {
                    studentData[id] = new Student
                    {
                        ID = id,
                        Name = values[1].Trim(),
                        Age = age
                    };
                }
            }
        }

        using (StreamReader reader = new StreamReader(file2))
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
                if (values.Length == 3 && int.TryParse(values[0], out int id) && int.TryParse(values[1], out int marks))
                {
                    if (studentData.ContainsKey(id))
                    {
                        studentData[id].Marks = marks;
                        studentData[id].Grade = values[2].Trim();
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            writer.WriteLine("ID,Name,Age,Marks,Grade");
            foreach (var student in studentData.Values)
            {
                writer.WriteLine(student);
            }
        }

        Console.WriteLine($"Merged CSV file '{outputFile}' created successfully!");
    }
}
