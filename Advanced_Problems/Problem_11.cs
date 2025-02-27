using System;
using System.IO;

class Program
{
    static void Main()
    {
        string csvFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\large_data.csv"; 
        int batchSize = 100; 
        int totalRecords = 0;

        try
        {
            using (StreamReader reader = new StreamReader(csvFile))
            {
                string line;
                bool isHeader = true;
                int batchCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) 
                    {
                        isHeader = false;
                        continue;
                    }

                    totalRecords++;
                    batchCount++;

                    if (batchCount == batchSize)
                    {
                        Console.WriteLine($"Processed {totalRecords} records so far...");
                        batchCount = 0; 
                    }
                }
            }
            Console.WriteLine($"Total records processed: {totalRecords}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading CSV file: {ex.Message}");
        }
    }
}
