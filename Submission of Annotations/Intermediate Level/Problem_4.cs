using System;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Method)]
class ImportantMethod : Attribute
{
    public string Level { get; set; }

    public ImportantMethod(string level = "HIGH")
    {
        Level = level;
    }
}

// Step 2: Apply the attribute to methods
class TaskManager
{
    [ImportantMethod("CRITICAL")]
    public void CriticalTask()
    {
        Console.WriteLine("Critical task executed");
    }

    [ImportantMethod]
    public void HighPriorityTask()
    {
        Console.WriteLine("High priority task executed");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve and print annotated methods
        var methods = typeof(TaskManager).GetMethods();
        foreach (var method in methods)
        {
            var attribute = (ImportantMethod)Attribute.GetCustomAttribute(method, typeof(ImportantMethod));
            if (attribute != null)
            {
                Console.WriteLine($"{method.Name} is important with level: {attribute.Level}");
            }
        }
    }
}