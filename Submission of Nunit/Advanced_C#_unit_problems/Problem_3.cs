public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}



using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [TestCase(0, 32)]
    [TestCase(100, 212)]
    [TestCase(-40, -40)]
    [TestCase(37, 98.6)]
    public void CelsiusToFahrenheit_ShouldReturnCorrectValues(double celsius, double expectedFahrenheit)
    {
        double result = converter.CelsiusToFahrenheit(celsius);
        Assert.AreEqual(expectedFahrenheit, result, 0.1); // Allow small floating-point precision errors
    }

    [TestCase(32, 0)]
    [TestCase(212, 100)]
    [TestCase(-40, -40)]
    [TestCase(98.6, 37)]
    public void FahrenheitToCelsius_ShouldReturnCorrectValues(double fahrenheit, double expectedCelsius)
    {
        double result = converter.FahrenheitToCelsius(fahrenheit);
        Assert.AreEqual(expectedCelsius, result, 0.1);
    }
}