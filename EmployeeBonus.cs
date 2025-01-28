// using System;

// class EmployeeBonus
// {
    // static void Main()
    // {
        // int[,] employeeData = GenerateEmployeeData(); 
        // double[,] newSalaryAndBonus = CalculateNewSalaryAndBonus(employeeData); 
        // CalculateAndDisplayTotals(employeeData, newSalaryAndBonus); 
    // }
    // public static int[,] GenerateEmployeeData() // Method to generate random salary (5-digit) and years of service for employees
    // {
        // Random rand = new Random();
        // int[,] employeeData = new int[10, 2]; // 2D Array to store salary and years of service for each employee

        // for (int i = 0; i < 10; i++)
        // {
            // employeeData[i, 0] = rand.Next(10000, 100000);
            // employeeData[i, 1] = rand.Next(1, 21);
        // }

        // return employeeData;
    // }
    // public static double[,] CalculateNewSalaryAndBonus(int[,] employeeData)  // Method to calculate new salary and bonus for employees based on years of service
    // {
        // double[,] newSalaryAndBonus = new double[10, 2]; // 2D Array to store new salary and bonus

        // for (int i = 0; i < 10; i++)
        // {
            // int oldSalary = employeeData[i, 0];
            // int yearsOfService = employeeData[i, 1];
            // double bonus = 0;
            // if (yearsOfService > 5)  // Calculate bonus based on years of service
            // {
                // bonus = oldSalary * 0.05; // 5% bonus if more than 5 years of service
            // }
            // else
            // {
                // bonus = oldSalary * 0.02; // 2% bonus if less than 5 years of service
            // }
            // double newSalary = oldSalary + bonus;

            // newSalaryAndBonus[i, 0] = newSalary; // Store new salary
            // newSalaryAndBonus[i, 1] = bonus;    // Store bonus amount
        // }

        // return newSalaryAndBonus;
    // }
    // public static void CalculateAndDisplayTotals(int[,] employeeData, double[,] newSalaryAndBonus) // Method to calculate and display the sum of old salaries, new salaries, and total bonus amount
    // {
        // double totalOldSalary = 0;
        // double totalNewSalary = 0;
        // double totalBonus = 0;

        // Console.WriteLine("Employee Bonus Details:");
        // Console.WriteLine("--------------------------------------------------");
        // Console.WriteLine("Employee | Old Salary | New Salary | Bonus");

        // for (int i = 0; i < 10; i++)
        // {
            // int oldSalary = employeeData[i, 0];
            // double newSalary = newSalaryAndBonus[i, 0];
            // double bonus = newSalaryAndBonus[i, 1];
            // Console.WriteLine("{0,8} | {1,10} | {2,10} | {3,5}", i + 1, oldSalary, newSalary, bonus); // Display employee's salary, new salary, and bonus

            // totalOldSalary += oldSalary;
            // totalNewSalary += newSalary;
            // totalBonus += bonus;
        // }

        // Console.WriteLine("--------------------------------------------------");
        // Console.WriteLine("Total Old Salary: {0}", totalOldSalary);
        // Console.WriteLine("Total New Salary: {0}", totalNewSalary);
        // Console.WriteLine("Total Bonus Amount: {0}", totalBonus);
    // }
// }
