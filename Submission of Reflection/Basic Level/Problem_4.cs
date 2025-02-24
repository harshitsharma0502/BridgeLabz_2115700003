using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = "Default Name";
        Age = 18;
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        // Create an instance dynamically using Reflection
        object obj = Activator.CreateInstance(type);

        // Invoke the Display method
        type.GetMethod("Display")?.Invoke(obj, null);
    }
}
