using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\employees.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        List<string> updatedRecords = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                {
                    updatedRecords.Add(line);
                    isHeader = false;
                    continue;
                }

                string[] values = line.Split(',');

                if (values.Length == 4 && values[2].Trim() == "IT")
                {
                    if (double.TryParse(values[3], out double salary))
                    {
                        salary *= 1.10;
                        values[3] = salary.ToString("F2");
                    }
                }

                updatedRecords.Add(string.Join(",", values));
            }
        }

        File.WriteAllLines(filePath, updatedRecords);

        Console.WriteLine("Salaries updated successfully in the same file!");
    }
}
