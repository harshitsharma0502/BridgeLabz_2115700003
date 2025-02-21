using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 70000 },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 60000 }
        };

        try
        {
            // Serialize the list of employees to JSON
            string jsonString = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Employees serialized successfully.");

            // Deserialize the list of employees from JSON
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                List<Employee> deserializedEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonData);
                Console.WriteLine("Deserialized Employees:");
                foreach (var emp in deserializedEmployees)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        catch (JsonException ex)
        {
            Console.WriteLine("Serialization error: " + ex.Message);
        }
    }
}