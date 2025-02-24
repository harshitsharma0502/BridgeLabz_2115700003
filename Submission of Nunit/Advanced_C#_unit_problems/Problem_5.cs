using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username cannot be empty.");

        if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Invalid email format.");

        if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters long.");
    }
}



using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration userRegistration;

    [SetUp]
    public void Setup()
    {
        userRegistration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ShouldNotThrowException_ForValidInput()
    {
        Assert.DoesNotThrow(() => userRegistration.RegisterUser("JohnDoe", "john@example.com", "SecurePass1"));
    }

    [Test]
    public void RegisterUser_ShouldThrowException_ForEmptyUsername()
    {
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("", "user@example.com", "ValidPass1"));
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser(null, "user@example.com", "ValidPass1"));
    }

    [Test]
    public void RegisterUser_ShouldThrowException_ForInvalidEmail()
    {
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "invalidemail", "ValidPass1"));
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "user@com", "ValidPass1"));
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "user@", "ValidPass1"));
    }

    [Test]
    public void RegisterUser_ShouldThrowException_ForWeakPassword()
    {
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "user@example.com", "short"));
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "user@example.com", ""));
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "user@example.com", null));
    }
}