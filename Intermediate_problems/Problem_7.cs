using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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

        List<string[]> employeeData = new List<string[]>();

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

                if (values.Length == 4 && double.TryParse(values[3], out double salary))
                {
                    employeeData.Add(values);
                }
            }
        }

        var sortedEmployees = employeeData.OrderByDescending(emp => double.Parse(emp[3])).Take(5);

        Console.WriteLine("Top 5 Highest-Paid Employees:");
        Console.WriteLine("ID\tName\t\tDepartment\tSalary");

        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp[0]}\t{emp[1]}\t{emp[2]}\t{emp[3]}");
        }
    }
}
