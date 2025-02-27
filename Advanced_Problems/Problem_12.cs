using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\StudentsDup.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        Dictionary<int, string> studentRecords = new Dictionary<int, string>();
        List<string> duplicateRecords = new List<string>();

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

                if (values.Length >= 2 && int.TryParse(values[0], out int id))
                {
                    if (studentRecords.ContainsKey(id))
                    {
                        duplicateRecords.Add(line);
                    }
                    else
                    {
                        studentRecords[id] = line;
                    }
                }
            }
        }

        if (duplicateRecords.Count > 0)
        {
            Console.WriteLine("Duplicate Records Found:");
            foreach (var record in duplicateRecords)
            {
                Console.WriteLine(record);
            }
        }
        else
        {
            Console.WriteLine("No duplicate records found.");
        }
    }
}
