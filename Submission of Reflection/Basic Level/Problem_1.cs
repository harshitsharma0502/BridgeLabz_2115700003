using System;
using System.Reflection;

class SampleClass
{
    public int Field1;
    private string Field2;

    public SampleClass() { }
    public SampleClass(int x) { }

    public void Method1() { }
    private void Method2() { }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();
        
        // Get Type using Reflection
        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo constructor in type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(constructor);
        }
    }
}
