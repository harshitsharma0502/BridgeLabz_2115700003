using System;
using System.Diagnostics;
using System.Reflection;

class TestClass
{
    public void FastMethod()
    {
        for (int i = 0; i < 1000; i++) { }
    }

    public void SlowMethod()
    {
        System.Threading.Thread.Sleep(500); // Simulating delay
    }
}

class MethodTimer
{
    public static void MeasureExecutionTime(object obj, string methodName)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        method.Invoke(obj, null);

        stopwatch.Stop();
        Console.WriteLine($"{methodName} executed in {stopwatch.ElapsedMilliseconds} ms");
    }
}

class Program
{
    static void Main()
    {
        TestClass testObj = new TestClass();

        MethodTimer.MeasureExecutionTime(testObj, "FastMethod");
        MethodTimer.MeasureExecutionTime(testObj, "SlowMethod");
    }
}
