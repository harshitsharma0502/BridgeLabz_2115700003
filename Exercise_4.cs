using System;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfo : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }

    public TaskInfo(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("HIGH", "John Doe")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed");
    }
}

class CustomAttribute
{
    static void Main()
    {
        var method = typeof(TaskManager).GetMethod("CompleteTask");
        var attribute = (TaskInfo)Attribute.GetCustomAttribute(method, typeof(TaskInfo));

        Console.WriteLine($"Priority: {attribute.Priority}, Assigned To: {attribute.AssignedTo}");
    }
}