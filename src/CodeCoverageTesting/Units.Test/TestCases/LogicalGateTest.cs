using Units.Logical;
using Xunit;

namespace Units.Test.TestCases;

public class LogicalGateTest
{
    [Fact]
    public void Should_BeFalse1()
    {
        Assert.False(LogicalGate.And(/*a*/ false, /*b*/ true));
    }

    [Fact]
    public void Should_BeFalse2()
    {
        Assert.False(LogicalGate.And(/*a*/ false, /*b*/ false));
    }

    [Fact]
    public void Should_BeFalse3()
    {
        Assert.False(LogicalGate.And(/*a*/ true, /*b*/ false));
    }

    [Fact]
    public void Should_BeTrue()
    {
        Assert.True(LogicalGate.And(/*a*/ true, /*b*/ true));
    }
}
