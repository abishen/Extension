using Extension.Tool.Services.Extensions;
namespace Extension.Tool.Test;

public class StringExtensionsTests
{

    [Test]
    public void StringRemoveWhiteSpaceExpected()
    {
        string value = "ABC JBJH";

        string? actual = value.ToRemoveWhiteSpace();
        Assert.That(actual, Is.EqualTo("ABCJBJH"));
    }

    [Test]
    public void StringIsNullRemoveWhiteSpaceNotExpected()
    {
        string value = null!;
        string? actual = value?.ToRemoveWhiteSpace();
        Assert.That(actual, Is.Null);
    }
}