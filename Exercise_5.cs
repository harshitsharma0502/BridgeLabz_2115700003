using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReport : Attribute
{
    public string Description { get; set; }

    public BugReport(string description)
    {
        Description = description;
    }
}

class BugTracker
{
    [BugReport("UI issue on login page")]
    [BugReport("Performance issue in dashboard")]
    public void ReportBugs()
    {
        Console.WriteLine("Bugs reported");
    }
}

class RepeatableAttribute
{
    static void Main()
    {
        var method = typeof(BugTracker).GetMethod("ReportBugs");
        var attributes = (BugReport[])Attribute.GetCustomAttributes(method, typeof(BugReport));

        foreach (var attribute in attributes)
        {
            Console.WriteLine($"Bug: {attribute.Description}");
        }
    }
}