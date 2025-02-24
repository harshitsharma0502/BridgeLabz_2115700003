[AttributeUsage(AttributeTargets.Method)]
class Todo : Attribute
{
    public string Task { get; set; }
    public string AssignedTo { get; set; }
    public string Priority { get; set; }

    public Todo(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Implement login feature", "Alice", "HIGH")]
    [Todo("Fix UI alignment", "Bob")]
    public void PendingTasks()
    {
        Console.WriteLine("Pending tasks listed");
    }
}

class Program
{
    static void Main()
    {
        var methods = typeof(Project).GetMethods();
        foreach (var method in methods)
        {
            var attributes = (Todo[])Attribute.GetCustomAttributes(method, typeof(Todo));
            foreach (var attribute in attributes)
            {
                Console.WriteLine($"Task: {attribute.Task}, Assigned To: {attribute.AssignedTo}, Priority: {attribute.Priority}");
            }
        }
    }
}