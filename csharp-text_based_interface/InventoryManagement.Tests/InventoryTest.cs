using NUnit.Framework;
using InventoryLibrary;


namespace InventoryManagement.Tests
{

public class Tests
{
    private User? _user;
    private Item? _item;
    private Inventory? _inventory;

    [SetUp]
    public void Setup()
    {
        
        _item = new Item("556");
        _inventory = new Inventory(_user.id, _item.id);
    }

    [Test]
    public void Test1()
    {
        var user = new User("Charlie Day");
        Assert.That(user.name, Is.EqualTo("Charlie Day"));
    }
}
}