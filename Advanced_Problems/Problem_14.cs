using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\students.json";
        string csvFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\converted_students.csv";
        string outputJsonFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\converted_students.json";

        ConvertJsonToCsv(jsonFile, csvFile);

        ConvertCsvToJson(csvFile, outputJsonFile);
    }

    static void ConvertJsonToCsv(string jsonFile, string csvFile)
    {
        if (!File.Exists(jsonFile))
        {
            Console.WriteLine("JSON file not found!");
            return;
        }

        string jsonData = File.ReadAllText(jsonFile);
        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

        using (StreamWriter writer = new StreamWriter(csvFile))
        {
            writer.WriteLine("ID,Name,Age,Marks");
            foreach (var student in students)
            {
                writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
            }
        }

        Console.WriteLine($"CSV file '{csvFile}' created successfully!");
    }

    static void ConvertCsvToJson(string csvFile, string jsonOutputFile)
    {
        if (!File.Exists(csvFile))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader(csvFile))
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
                    students.Add(new Student
                    {
                        ID = id,
                        Name = values[1].Trim(),
                        Age = age,
                        Marks = marks
                    });
                }
            }
        }

        string jsonOutput = JsonConvert.SerializeObject(students, Formatting.Indented);
        File.WriteAllText(jsonOutputFile, jsonOutput);

        Console.WriteLine($"JSON file '{jsonOutputFile}' created successfully!");
    }
}
