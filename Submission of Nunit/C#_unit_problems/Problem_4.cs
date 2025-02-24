using System;

public class Calculator
{
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new ArithmeticException("Division by zero is not allowed.");
        
        return a / b;
    }
}



using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        Assert.AreEqual(2, calculator.Divide(10, 5));
        Assert.AreEqual(-3, calculator.Divide(-9, 3));
    }

    [Test]
    public void Divide_ShouldThrowArithmeticException_WhenDividingByZero()
    {
        var ex = Assert.Throws<ArithmeticException>(() => calculator.Divide(10, 0));
        Assert.AreEqual("Division by zero is not allowed.", ex.Message);
    }
}