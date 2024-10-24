namespace GuidTimeTests;

namespace GuidTimeTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var d = DateTime.Parse("March 2, 2004");//what will that give us?
        d.Year.Should().Be(2004);
        d.Month.Should().Be(3);
        d.Day.Should().Be(2);
    }
}