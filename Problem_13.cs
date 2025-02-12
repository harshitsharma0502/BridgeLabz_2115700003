using System;

public class Employee
{
    // Public field for employee ID
    public string EmployeeID;

    // Protected field for department
    protected string Department;

    // Private field for salary
    private decimal salary;

    // Constructor to initialize the employee
    public Employee(string employeeID, string department, decimal initialSalary = 0.0m)
    {
        EmployeeID = employeeID;
        Department = department;
        salary = initialSalary;
    }

    // Public method to modify the salary
    public void ModifySalary(decimal newSalary)
    {
        if (newSalary >= 0)
        {
            salary = newSalary;
        }
        else
        {
            Console.WriteLine("Salary cannot be negative.");
        }
    }

    // Public method to access the salary
    public decimal GetSalary()
    {
        return salary;
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {salary:C}");
    }
}

public class Manager : Employee
{
    // Constructor for Manager subclass
    public Manager(string employeeID, string department, decimal initialSalary = 0.0m)
        : base(employeeID, department, initialSalary)
    {
    }

    // Method to display manager details
    public void DisplayManagerDetails()
    {
        Console.WriteLine($"Manager Employee ID: {EmployeeID}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {GetSalary():C}");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating an Employee
        Employee employee = new Employee("E123", "HR", 50000.0m);
        employee.DisplayEmployeeDetails();
        employee.ModifySalary(55000.0m);
        employee.DisplayEmployeeDetails();

        // Creating a Manager
        Manager manager = new Manager("M456", "IT", 75000.0m);
        manager.DisplayManagerDetails();
        manager.ModifySalary(80000.0m);
        manager.DisplayManagerDetails();
    }
}