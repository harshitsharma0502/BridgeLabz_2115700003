using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment34\\employees.csv";


        string[] employees = {
            "ID,Name,Department,Salary",
            "1,John Doe,IT,60000",
            "2,Jane Smith,HR,55000",
            "3,Michael Johnson,Finance,70000",
            "4,Emily Davis,Marketing,65000",
            "5,Robert Brown,Operations,62000"
        };


        File.WriteAllLines(filePath, employees);

        Console.WriteLine("Employee data has been written to " + filePath);
    }
}
