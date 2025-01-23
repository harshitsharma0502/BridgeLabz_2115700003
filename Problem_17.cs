using System;

class EmployeeBonus
{
    public static void Main(string[] args)
    {
            Console.Write("Enter the employee's salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter the years of service: ");
            int yearsOfService = int.Parse(Console.ReadLine());
            if (yearsOfService > 5)
            {
                double bonus = salary * 0.05; // Calculate 5% bonus
                Console.WriteLine("The bonus amount is: {0}", bonus);
            }
            else
            {
                Console.WriteLine("No bonus for employees with 5 or fewer years of service.");
            }
    }
}
