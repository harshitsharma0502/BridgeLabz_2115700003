using System;
using System.IO;

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

        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine().Trim().ToLower();
        bool found = false;

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

                if (values.Length == 4 && values[1].Trim().ToLower() == searchName)
                {
                    Console.WriteLine($"Employee Found: \nDepartment: {values[2]}\nSalary: {values[3]}");
                    found = true;
                    break;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
