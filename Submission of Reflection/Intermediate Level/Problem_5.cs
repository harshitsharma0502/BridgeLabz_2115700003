using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        MathOperations mathOps = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        MethodInfo methodInfo = type.GetMethod(methodName);
        if (methodInfo != null)
        {
            // Invoke the method dynamically
            object result = methodInfo.Invoke(mathOps, new object[] { 10, 5 });
            Console.WriteLine($"Result of {methodName}(10, 5): {result}");
        }
        else
        {
            Console.WriteLine("Method not found!");
        }
    }
}
