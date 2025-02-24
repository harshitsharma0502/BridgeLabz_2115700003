using System;
using System.Globalization;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (string.IsNullOrEmpty(inputDate))
            throw new ArgumentException("Input date cannot be null or empty.");

        if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            throw new FormatException("Invalid date format. Expected format: yyyy-MM-dd");

        return date.ToString("dd-MM-yyyy");
    }
}


using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter dateFormatter;

    [SetUp]
    public void Setup()
    {
        dateFormatter = new DateFormatter();
    }

    [TestCase("2025-02-22", "22-02-2025")]
    [TestCase("2000-01-01", "01-01-2000")]
    [TestCase("1999-12-31", "31-12-1999")]
    public void FormatDate_ShouldReturnCorrectFormattedDate(string input, string expected)
    {
        string result = dateFormatter.FormatDate(input);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void FormatDate_ShouldThrowException_ForInvalidFormat()
    {
        Assert.Throws<FormatException>(() => dateFormatter.FormatDate("22-02-2025"));
        Assert.Throws<FormatException>(() => dateFormatter.FormatDate("02/22/2025"));
        Assert.Throws<FormatException>(() => dateFormatter.FormatDate("20250222"));
    }

    [Test]
    public void FormatDate_ShouldThrowException_ForEmptyOrNullInput()
    {
        Assert.Throws<ArgumentException>(() => dateFormatter.FormatDate(""));
        Assert.Throws<ArgumentException>(() => dateFormatter.FormatDate(null));
    }
}