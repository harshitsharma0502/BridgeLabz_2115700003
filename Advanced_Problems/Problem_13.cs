using System;
using System.Data.SqlClient;
using System.IO;

class Program
{
    static void Main()
    {
        string connectionString = "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;";
        string csvFilePath = "employees.csv";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                using (StreamWriter writer = new StreamWriter(csvFilePath))
                {
                    writer.WriteLine("Employee ID,Name,Department,Salary");

                    while (reader.Read())
                    {
                        writer.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                    }
                }
            }

            Console.WriteLine($"CSV report '{csvFilePath}' generated successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


// C:\\Users\\Somil\\Desktop\\BL_Assgn\\Assignment28\\