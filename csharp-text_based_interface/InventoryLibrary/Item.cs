using System;

namespace InventoryLibrary
{
public class Item : BaseClass
{
    public string name { get; set; }

    public Item(string name)
    {
        if (name != null && name != "")
        {
            this.name = name;
        }
    }
}
}