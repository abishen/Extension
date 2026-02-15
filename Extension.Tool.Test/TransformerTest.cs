using Extension.Tool.Services;

namespace Extension.Tool.Test;
[TestFixture]
public class TransformerTest
{
    private ITransformer _transformer = null!;
    [Test]
    public void Transform_Expected()
    {
        _transformer = new TransfomerMapping();

        var personDto = new PersonDto()
        {
            Name = "Dillon",
            Age = 18,
            LastName = "Dhayanandan"
        };

        var actual = _transformer.Transform<PersonDto, Person>(personDto);
        Assert.That(actual, Is.Not.Null);
        Assert.That(actual.Name, Is.EqualTo("Dillon"));
        Assert.That(actual.Age, Is.EqualTo(18));
    }

}

public class PersonDto
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? LastName { get; set; }
}

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? LastName { get; set; }
}