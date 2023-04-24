namespace Library.Tests;
using NUnit.Framework;
using TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        const string input = "19/10/2000";
        const string expected = "2000-10-19";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void WrongSeparationFormat()
    {
        const string input = "19-10-2000";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void IncorrectFormat()
    {
        const string input = "19/10/20000";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

}