using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\Students.csv"; // Ensure the file exists

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            bool isHeader = true;
            Console.WriteLine("Students with Marks > 80:\n");

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                string[] values = line.Split(',');

                if (values.Length == 4 && int.TryParse(values[3], out int marks) && marks > 80)
                {
                    Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Age: {values[2]}, Marks: {values[3]}");
                }
            }
        }
    }
}
