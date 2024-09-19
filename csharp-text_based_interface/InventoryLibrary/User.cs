using System;

namespace InventoryLibrary
{
public class User : BaseClass
{
    public string name { get; set; }

    public User(string name)
    {
        if (string.NullOrEmpty(name))
        {
            throw new ArgumentException("Invalid name format.");
        }
        this.name = name;
    }
}
}