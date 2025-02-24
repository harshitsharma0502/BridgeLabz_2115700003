using System;
using System.Reflection;

class Person
{
    private int age = 25;
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);

        // Get private field using Reflection
        FieldInfo fieldInfo = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (fieldInfo != null)
        {
            // Get current value of private field
            Console.WriteLine("Original Age: " + fieldInfo.GetValue(person));

            // Modify the private field value
            fieldInfo.SetValue(person, 30);
            Console.WriteLine("Modified Age: " + fieldInfo.GetValue(person));
        }
        else
        {
            Console.WriteLine("Field not found!");
        }
    }
}
