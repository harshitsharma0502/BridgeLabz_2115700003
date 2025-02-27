using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public string Salary { get; set; } 
}

class Program
{
    static readonly string EncryptionKey = "MySecretKey12345"; 

    static void Main()
    {
        string csvFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\employees.csv";

        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "John Doe", Department = "IT", Email = "john@example.com", Salary = "75000" },
            new Employee { ID = 2, Name = "Jane Smith", Department = "HR", Email = "jane@example.com", Salary = "65000" },
            new Employee { ID = 3, Name = "Robert Brown", Department = "Finance", Email = "robert@example.com", Salary = "85000" }
        };

        WriteEncryptedCsv(csvFile, employees);

        ReadDecryptedCsv(csvFile);
    }

    static void WriteEncryptedCsv(string filePath, List<Employee> employees)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("ID,Name,Department,Email,Salary"); // Header
            foreach (var emp in employees)
            {
                string encryptedEmail = Encrypt(emp.Email);
                string encryptedSalary = Encrypt(emp.Salary);
                writer.WriteLine($"{emp.ID},{emp.Name},{emp.Department},{encryptedEmail},{encryptedSalary}");
            }
        }

        Console.WriteLine($"Encrypted CSV file '{filePath}' created successfully!");
    }

    static void ReadDecryptedCsv(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            bool isHeader = true;

            Console.WriteLine("\nDecrypted Employee Data:");
            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader) 
                {
                    isHeader = false;
                    continue;
                }

                string[] values = line.Split(',');
                if (values.Length == 5)
                {
                    string decryptedEmail = Decrypt(values[3]);
                    string decryptedSalary = Decrypt(values[4]);

                    Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Department: {values[2]}, Email: {decryptedEmail}, Salary: {decryptedSalary}");
                }
            }
        }
    }

    static string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
            aes.IV = new byte[16]; 

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Convert.ToBase64String(encryptedBytes);
        }
    }

    static string Decrypt(string cipherText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
            aes.IV = new byte[16]; 

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] encryptedBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}
