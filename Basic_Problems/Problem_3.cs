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

        int recordCount = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            bool isHeader = true;
            while (reader.ReadLine() != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }
                recordCount++;
            }
        }

        Console.WriteLine($"Total number of records (excluding header): {recordCount}");
    }
}
