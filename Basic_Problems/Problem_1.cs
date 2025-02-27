using System;
using System.IO;

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

                if (values.Length == 4)
                {
                    Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Age: {values[2]}, Marks: {values[3]}");
                }
            }
        }
    }
}
