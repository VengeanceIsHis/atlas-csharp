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
        _user = new User("Charlie Day");
        _item = new Item("556");
        _inventory = new Inventory(_user.id, _item.id);
    }

    [Test]
    public void Test1()
    {
        Assert.That(_user.name, Is.EqualTo("Charlier Day"));
    }
}
}