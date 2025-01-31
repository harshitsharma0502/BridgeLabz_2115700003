using System;
public class Employee
{
    // Attributes
    private string name;
    private int id;
    private double salary;
	
    // Constructor to initialize attributes
    public Employee(string EmpName, int EmpId, double EmpSalary)
    {
        name = EmpName;
        id = EmpId;
        salary = EmpSalary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Salary: " + salary);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Taking input from the user
        Console.WriteLine("Enter employee name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter employee ID:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee salary:");
        double salary = double.Parse(Console.ReadLine());

        // Create Employee object
        Employee employee1 = new Employee(name, id, salary);

        // Display employee details
        employee1.DisplayDetails();
    }
}
