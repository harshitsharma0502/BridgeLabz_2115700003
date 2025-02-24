using System;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (string.IsNullOrEmpty(password))
            return false;

        return password.Length >= 8 &&
               Regex.IsMatch(password, @"[A-Z]") && // At least one uppercase letter
               Regex.IsMatch(password, @"\d");     // At least one digit
    }
}



using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void IsValid_ShouldReturnTrue_ForStrongPasswords()
    {
        Assert.IsTrue(validator.IsValid("StrongP@ss1"));
        Assert.IsTrue(validator.IsValid("HelloWorld9"));
        Assert.IsTrue(validator.IsValid("SecurePass123"));
    }

    [Test]
    public void IsValid_ShouldReturnFalse_ForShortPasswords()
    {
        Assert.IsFalse(validator.IsValid("Pass1"));
        Assert.IsFalse(validator.IsValid("HiA7"));
    }

    [Test]
    public void IsValid_ShouldReturnFalse_WhenNoUppercaseLetter()
    {
        Assert.IsFalse(validator.IsValid("password123"));
    }

    [Test]
    public void IsValid_ShouldReturnFalse_WhenNoDigit()
    {
        Assert.IsFalse(validator.IsValid("PasswordOnly"));
    }

    [Test]
    public void IsValid_ShouldReturnFalse_ForEmptyOrNullPasswords()
    {
        Assert.IsFalse(validator.IsValid(""));
        Assert.IsFalse(validator.IsValid(null));
    }
}