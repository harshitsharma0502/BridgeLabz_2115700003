using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTime : Attribute
{
    public void Log(Action method)
    {
        Stopwatch sw = Stopwatch.StartNew();
        method();
        sw.Stop();
        Console.WriteLine($"Execution time: {sw.ElapsedMilliseconds} ms");
    }
}

class Calculator
{
    [LogExecutionTime]
    public void Add()
    {
        int sum = 0;
        for (int i = 0; i < 1000000; i++)
        {
            sum += i;
        }
        Console.WriteLine("Addition completed");
    }
}

class Program
{
    static void Main()
    {
        var calculator = new Calculator();
        var method = typeof(Calculator).GetMethod("Add");
        var attribute = (LogExecutionTime)Attribute.GetCustomAttribute(method, typeof(LogExecutionTime));
        attribute.Log(() => calculator.Add());
    }
}