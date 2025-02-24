using System;
using System.Threading;

public class PerformanceTester
{
    public string LongRunningTask()
    {
        Thread.Sleep(3000); // Simulating a long-running process (3 seconds)
        return "Task Completed";
    }
}


using NUnit.Framework;

[TestFixture]
public class PerformanceTesterTests
{
    private PerformanceTester performanceTester;

    [SetUp]
    public void Setup()
    {
        performanceTester = new PerformanceTester();
    }

    [Test]
    [Timeout(2000)] // Test should fail if it takes more than 2 seconds
    public void LongRunningTask_ShouldFailDueToTimeout()
    {
        string result = performanceTester.LongRunningTask();
        Assert.AreEqual("Task Completed", result);
    }
}