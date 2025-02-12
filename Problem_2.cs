using System;

public class Employee  // Base class: Employee
{
   public string Name { get; set; }
   public int Id { get; set; }
   public double Salary { get; set; }

   public Employee(string name, int id, double salary)
   {
       Name = name;
       Id = id;
       Salary = salary;
   }

   public virtual void DisplayDetails()
   {
       Console.WriteLine($"Employee Name: {Name}, ID: {Id}, Salary: ${Salary:F2}");
   }
}

public class Manager : Employee // Subclass: Manager
{
   public int TeamSize { get; set; }

   public Manager(string name, int id, double salary, int teamSize)
       : base(name, id, salary)
   {
       TeamSize = teamSize;
   }

   public override void DisplayDetails()
   {
       base.DisplayDetails();
       Console.WriteLine($"Role: Manager, Team Size: {TeamSize}");
   }
}

public class Developer : Employee // Subclass: Developer
{
   public string ProgrammingLanguage { get; set; }

   public Developer(string name, int id, double salary, string programmingLanguage)
       : base(name, id, salary)
   {
       ProgrammingLanguage = programmingLanguage;
   }

   public override void DisplayDetails()
   {
       base.DisplayDetails();
       Console.WriteLine($"Role: Developer, Programming Language: {ProgrammingLanguage}");
   }
}

public class Intern : Employee    // Subclass: Intern
{
   public string InternshipDuration { get; set; }

   public Intern(string name, int id, double salary, string internshipDuration)
       : base(name, id, salary)
   {
       InternshipDuration = internshipDuration;
   }

   public override void DisplayDetails()
   {
       base.DisplayDetails();
       Console.WriteLine($"Role: Intern, Internship Duration: {InternshipDuration}");
   }
}

class Program
{
   static void Main(string[] args)
   {
       Employee manager = new Manager("Alice", 101, 80000, 5);
       Employee developer = new Developer("Bob", 102, 70000, "C#");
       Employee intern = new Intern("Charlie", 103, 20000, "6 months");

       manager.DisplayDetails();
       Console.WriteLine();

       developer.DisplayDetails();
       Console.WriteLine();

       intern.DisplayDetails();
   }
}
