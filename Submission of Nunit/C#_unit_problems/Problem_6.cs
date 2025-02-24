using System;
public class NumberUtils
{
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}



using NUnit.Framework;

[TestFixture]
public class NumberUtilsTests
{
    private NumberUtils numberUtils;

    [SetUp]
    public void Setup()
    {
        numberUtils = new NumberUtils();
    }

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_ShouldReturnCorrectResult(int number, bool expected)
    {
        bool result = numberUtils.IsEven(number);
        Assert.AreEqual(expected, result);
    }
}