using System;


public class Item : BaseClass
{
    public string name { get; set; }

    public Item(string name)
    {
        this.name = name;
    }
}