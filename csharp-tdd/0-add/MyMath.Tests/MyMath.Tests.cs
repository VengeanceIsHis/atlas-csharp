namespace MyMath.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int a = 3;
        int b = 4;
        int expected = 7;

        int result = Operations.Add(a, b)

        Assert.AreEqual(expected, result);
    }
}