using System;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect()
    {
        if (IsConnected)
            throw new InvalidOperationException("Already connected to the database.");
        
        IsConnected = true;
        Console.WriteLine("Database connected.");
    }

    public void Disconnect()
    {
        if (!IsConnected)
            throw new InvalidOperationException("Database is not connected.");
        
        IsConnected = false;
        Console.WriteLine("Database disconnected.");
    }
}


using NUnit.Framework;
using System;

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection dbConnection;

    [SetUp]
    public void Setup()
    {
        dbConnection = new DatabaseConnection();
        dbConnection.Connect();  // Establish connection before each test
    }

    [TearDown]
    public void Teardown()
    {
        dbConnection.Disconnect();  // Close connection after each test
    }

    [Test]
    public void Connect_ShouldSetIsConnectedToTrue()
    {
        Assert.IsTrue(dbConnection.IsConnected);
    }

    [Test]
    public void Disconnect_ShouldSetIsConnectedToFalse()
    {
        dbConnection.Disconnect();
        Assert.IsFalse(dbConnection.IsConnected);
    }

    [Test]
    public void Connect_ShouldThrowException_IfAlreadyConnected()
    {
        Assert.Throws<InvalidOperationException>(() => dbConnection.Connect());
    }

    [Test]
    public void Disconnect_ShouldThrowException_IfNotConnected()
    {
        dbConnection.Disconnect(); // First disconnect
        Assert.Throws<InvalidOperationException>(() => dbConnection.Disconnect());
    }
}