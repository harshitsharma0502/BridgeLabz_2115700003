using System;

public class StringUtils
{
    public string Reverse(string str)
    {
        if (str == null) throw new ArgumentNullException(nameof(str));
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public bool IsPalindrome(string str)
    {
        if (str == null) throw new ArgumentNullException(nameof(str));
        string reversed = Reverse(str);
        return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str)
    {
        if (str == null) throw new ArgumentNullException(nameof(str));
        return str.ToUpper();
    }
}


using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    private StringUtils stringUtils;

    [SetUp]
    public void Setup()
    {
        stringUtils = new StringUtils();
    }

    [Test]
    public void Reverse_ShouldReturnReversedString()
    {
        Assert.AreEqual("olleh", stringUtils.Reverse("hello"));
        Assert.AreEqual("321", stringUtils.Reverse("123"));
    }

    [Test]
    public void Reverse_ShouldHandleEmptyString()
    {
        Assert.AreEqual("", stringUtils.Reverse(""));
    }

    [Test]
    public void Reverse_ShouldThrowException_ForNullInput()
    {
        Assert.Throws<ArgumentNullException>(() => stringUtils.Reverse(null));
    }

    [Test]
    public void IsPalindrome_ShouldReturnTrue_ForPalindromes()
    {
        Assert.IsTrue(stringUtils.IsPalindrome("madam"));
        Assert.IsTrue(stringUtils.IsPalindrome("racecar"));
        Assert.IsTrue(stringUtils.IsPalindrome("Level"));
    }

    [Test]
    public void IsPalindrome_ShouldReturnFalse_ForNonPalindromes()
    {
        Assert.IsFalse(stringUtils.IsPalindrome("hello"));
        Assert.IsFalse(stringUtils.IsPalindrome("world"));
    }

    [Test]
    public void IsPalindrome_ShouldThrowException_ForNullInput()
    {
        Assert.Throws<ArgumentNullException>(() => stringUtils.IsPalindrome(null));
    }

    [Test]
    public void ToUpperCase_ShouldConvertToUpperCase()
    {
        Assert.AreEqual("HELLO", stringUtils.ToUpperCase("hello"));
        Assert.AreEqual("TEST", stringUtils.ToUpperCase("TeSt"));
    }

    [Test]
    public void ToUpperCase_ShouldHandleEmptyString()
    {
        Assert.AreEqual("", stringUtils.ToUpperCase(""));
    }

    [Test]
    public void ToUpperCase_ShouldThrowException_ForNullInput()
    {
        Assert.Throws<ArgumentNullException>(() => stringUtils.ToUpperCase(null));
    }
}