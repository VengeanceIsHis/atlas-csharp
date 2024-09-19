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
    public void SuccesfulUser()
    {
        var user = new User("Charlie Day");
        Assert.That(user.name, Is.EqualTo("Charlie Day"));
    }
    [Test]
    public void NumericUser()
    {
        var user = new User(46);
        Assert.That(user.name, Is.EqualTo("Charlie Day"));
    }
    [Test]
    public void Mass
}
}