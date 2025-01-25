using System;

class EmployeeBonusCalculator
{
    static void Main()
    {
        const int NumberOfEmployees = 10;

        // Arrays to store employee data
        double[] salaries = new double[NumberOfEmployees];
        double[] yearsOfService = new double[NumberOfEmployees];
        double[] bonuses = new double[NumberOfEmployees];
        double[] newSalaries = new double[NumberOfEmployees];

        // Variables for totals
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;

        // Input loop
        for (int i = 0; i < NumberOfEmployees; i++)
        {
            // Input salary
            Console.WriteLine("Enter salary for employee " + (i + 1) + ":");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary <= 0)
            {
                Console.WriteLine("Invalid input! Salary must be a positive number. Please enter again.");
                i--; // Decrement index to allow re-entering the input
                continue;
            }

            // Input years of service
            Console.WriteLine("Enter years of service for employee " + (i + 1) + ":");
            double years = Convert.ToDouble(Console.ReadLine());
            if (years < 0)
            {
                Console.WriteLine("Invalid input! Years of service must be a non-negative number. Please enter again.");
                i--; // Decrement index to allow re-entering the input
                continue;
            }

            // Store the valid inputs
            salaries[i] = salary;
            yearsOfService[i] = years;
        }

        // Calculation loop
        for (int i = 0; i < NumberOfEmployees; i++)
        {
            // Calculate bonus
            if (yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05; // 5% bonus
            }
            else
            {
                bonuses[i] = salaries[i] * 0.02; // 2% bonus
            }

            // Calculate new salary
            newSalaries[i] = salaries[i] + bonuses[i];

            // Update totals
            totalOldSalary += salaries[i];
            totalBonus += bonuses[i];
            totalNewSalary += newSalaries[i];
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Total Old Salary: " + totalOldSalary.ToString("F2"));
        Console.WriteLine("Total Bonus: " + totalBonus.ToString("F2"));
        Console.WriteLine("Total New Salary: " + totalNewSalary.ToString("F2"));
    }
}
