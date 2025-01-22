using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter Bonus: ");
        double bonus = double.Parse(Console.ReadLine());

        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR {0} and bonus is INR {1}.Hence Total Income is INR {2}", salary, bonus, totalIncome);
    }
}
