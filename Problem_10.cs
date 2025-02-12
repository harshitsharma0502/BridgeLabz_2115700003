
using System;
public class Person
{
   public string Name { get; set; }
   public int Id { get; set; }

   public Person(string name, int id)
   {
       Name = name;
       Id = id;
   }

   public void DisplayInfo()
   {
       Console.WriteLine($"Name: {Name}, ID: {Id}");
   }
}

public interface Worker
{
   void PerformDuties();
}

public class Chef : Person, Worker
{
   public string Specialty { get; set; }

   public Chef(string name, int id, string specialty)
       : base(name, id)
   {
       Specialty = specialty;
   }

   public void PerformDuties()
   {
       Console.WriteLine($"Chef {Name} (ID: {Id}) is preparing dishes with a specialty in {Specialty}.");
   }
}

public class Waiter : Person, Worker
{
   public int TableCount { get; set; }

   public Waiter(string name, int id, int tableCount)
       : base(name, id)
   {
       TableCount = tableCount;
   }

   public void PerformDuties()
   {
       Console.WriteLine($"Waiter {Name} (ID: {Id}) is serving {TableCount} tables.");
   }
}

class Program
{
   static void Main(string[] args)
   {
       Chef chef = new Chef("Gordon Ramsay", 101, "Italian Cuisine");
       Waiter waiter = new Waiter("John Doe", 202, 5);
       chef.DisplayInfo();
       chef.PerformDuties();

       Console.WriteLine("\n");

       waiter.DisplayInfo();
       waiter.PerformDuties();
   }
}

