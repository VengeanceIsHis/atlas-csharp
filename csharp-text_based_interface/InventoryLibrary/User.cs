using System;

namespace InventoryLibrary
{
public class User : BaseClass
{
    public string name { get; set; }

    public User(string name)
    {
        if (name == null || name == "")
        {
            throw new ArgumentException("Invalid name format.");
        }
        this.name = name;
    }
}
}