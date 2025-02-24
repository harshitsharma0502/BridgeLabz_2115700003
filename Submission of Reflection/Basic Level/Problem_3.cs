using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);

        // Get private method using Reflection
        MethodInfo methodInfo = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (methodInfo != null)
        {
            // Invoke private method
            object result = methodInfo.Invoke(calc, new object[] { 5, 4 });
            Console.WriteLine("Result of Multiply(5, 4): " + result);
        }
        else
        {
            Console.WriteLine("Method not found!");
        }
    }
}
