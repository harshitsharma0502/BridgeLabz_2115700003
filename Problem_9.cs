using System;

public class Person
{
   public string Name { get; set; }
   public int Age { get; set; }

   public Person(string name, int age)
   {
       Name = name;
       Age = age;
   }

   public virtual void DisplayRole()
   {
       Console.WriteLine($"Name: {Name}, Age: {Age}");
   }
}
public class Teacher : Person
{
   public string Subject { get; set; }

   public Teacher(string name, int age, string subject)
       : base(name, age)
   {
       Subject = subject;
   }

   public override void DisplayRole()
   {
       base.DisplayRole();
       Console.WriteLine($"Role: Teacher, Subject: {Subject}");
   }
}
public class Student : Person
{
   public string Grade { get; set; }

   public Student(string name, int age, string grade)
       : base(name, age)
   {
       Grade = grade;
   }

   public override void DisplayRole()
   {
       base.DisplayRole();
       Console.WriteLine($"Role: Student, Grade: {Grade}");
   }
}

public class Staff : Person
{
   public string Department { get; set; }

   public Staff(string name, int age, string department)
       : base(name, age)
   {
       Department = department;
   }

   public override void DisplayRole()
   {
       base.DisplayRole();
       Console.WriteLine($"Role: Staff, Department: {Department}");
   }
}

class Program
{
   static void Main(string[] args)
   {
       Teacher teacher = new Teacher("Mr. John", 45, "Mathematics");
       teacher.DisplayRole();
       Student student = new Student("Alice", 16, "10th Grade");
       student.DisplayRole();
       Staff staff = new Staff("Ms. Emily", 40, "Administration");
       staff.DisplayRole();
   }
}
