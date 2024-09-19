using System;


public class Inventory : BaseClass
{
    public User id { get; private set; }
    public Item item_id { get; private set }
    public int quantity { get; private set }
}