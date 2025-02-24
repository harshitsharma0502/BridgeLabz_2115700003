using System;
using NUnit.Framework;

// Calculator Class
public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}


// NUnit Test Class
[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_WhenCalled_ReturnsSum()
    {
        Assert.AreEqual(5, _calculator.Add(2, 3));
    }

    [Test]
    public void Subtract_WhenCalled_ReturnsDifference()
    {
        Assert.AreEqual(1, _calculator.Subtract(4, 3));
    }

    [Test]
    public void Multiply_WhenCalled_ReturnsProduct()
    {
        Assert.AreEqual(6, _calculator.Multiply(2, 3));
    }

    [Test]
    public void Divide_WhenCalled_ReturnsQuotient()
    {
        Assert.AreEqual(2, _calculator.Divide(6, 3));
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
    }
}