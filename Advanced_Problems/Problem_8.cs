using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\employee_details.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        string phonePattern = @"^\d{10}$";

        List<string> invalidRecords = new List<string>();

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

                if (values.Length < 6)
                {
                    invalidRecords.Add($"Invalid row (Missing columns): {line}");
                    continue;
                }

                string email = values[2].Trim();
                string phone = values[3].Trim();

                bool isEmailValid = Regex.IsMatch(email, emailPattern);
                bool isPhoneValid = Regex.IsMatch(phone, phonePattern);

                if (!isEmailValid || !isPhoneValid)
                {
                    string errorMessage = $"Invalid row: {line} -> ";
                    if (!isEmailValid) errorMessage += "Invalid Email Format. ";
                    if (!isPhoneValid) errorMessage += "Invalid Phone Number.";
                    invalidRecords.Add(errorMessage);
                }
            }
        }
        if (invalidRecords.Count > 0)
        {
            Console.WriteLine("Invalid Rows Found:");
            foreach (var record in invalidRecords)
            {
                Console.WriteLine(record);
            }
        }
        else
        {
            Console.WriteLine("All records are valid.");
        }
    }
}
