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
        Assert.That(user.name, Is.EqualTo("Charlie Day"));
    }
}
}