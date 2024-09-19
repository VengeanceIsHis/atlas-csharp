using NUnit.Framework;
using InventoryLibrary;


namespace InventoryManagement.Tests
{

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var user = new User("Charlie Day");
        Assert.AreEqual("Charlie Day", user.name);
    }
}
}