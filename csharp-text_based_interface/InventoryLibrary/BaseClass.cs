namespace InventoryLibrary
{

public class BaseClass
{
    public string id { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }

    public BaseClass()
    {
        this.id = Guid.NewGuid().ToString();
        this.date_created = DateTime.UtcNow;
        this.date_updated = DateTime.UtcNow;
    }

    public void Update()
    {
        this.date_updated = DateTime.UtcNow;
    }
}
}