using System;
using System.Collections.Generic;

// Abstract Class Employee
public abstract class Employee
{
    private int employeeId;
    private string name;
    private decimal baseSalary;

    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    public Employee(int employeeId, string name, decimal baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // Abstract method for calculating salary
    public abstract decimal CalculateSalary();

    // Concrete method for displaying details
    public void DisplayDetails()
    {
        Console.WriteLine($"Employee ID: {employeeId}\nName: {name}\nBase Salary: {baseSalary:C}\nTotal Salary: {CalculateSalary():C}\n");
    }
}

// Interface for Department Management
public interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

// Full-Time Employee Class
public class FullTimeEmployee : Employee, IDepartment
{
    private decimal fixedSalary;
    private string departmentName;

    public decimal FixedSalary
    {
        get { return fixedSalary; }
        set { fixedSalary = value; }
    }

    public FullTimeEmployee(int employeeId, string name, decimal baseSalary, decimal fixedSalary)
        : base(employeeId, name, baseSalary)
    {
        this.fixedSalary = fixedSalary;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + fixedSalary;
    }

    public void AssignDepartment(string departmentName)
    {
        this.departmentName = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {departmentName}";
    }
}

// Part-Time Employee Class
public class PartTimeEmployee : Employee, IDepartment
{
    private int workHours;
    private decimal hourlyRate;
    private string departmentName;

    public int WorkHours
    {
        get { return workHours; }
        set { workHours = value; }
    }

    public decimal HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public PartTimeEmployee(int employeeId, string name, decimal baseSalary, int workHours, decimal hourlyRate)
        : base(employeeId, name, baseSalary)
    {
        this.workHours = workHours;
        this.hourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + (workHours * hourlyRate);
    }

    public void AssignDepartment(string departmentName)
    {
        this.departmentName = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {departmentName}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Alice", 50000, 20000) { FixedSalary = 20000 },
            new PartTimeEmployee(2, "Bob", 15000, 20, 500)
        };

        foreach (Employee employee in employees)
        {
            employee.DisplayDetails();
        }

        FullTimeEmployee fullTimeEmp = new FullTimeEmployee(3, "Charlie", 60000, 25000);
        fullTimeEmp.AssignDepartment("HR");
        Console.WriteLine(fullTimeEmp.GetDepartmentDetails());

        PartTimeEmployee partTimeEmp = new PartTimeEmployee(4, "David", 10000, 30, 400);
        partTimeEmp.AssignDepartment("Marketing");
        Console.WriteLine(partTimeEmp.GetDepartmentDetails());
    }
}
