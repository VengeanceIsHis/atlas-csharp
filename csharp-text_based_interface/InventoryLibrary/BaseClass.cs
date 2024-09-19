namespace InventoryLibrary;

public class BaseClass
{
    public string id { get; set }
    public DateTime date_created { get; set }
    public DateTime date_updated { get; set }

    public BaseClass()
    {
        this.id = Guid.NewGuid().ToString();
        this.datecreated = DateTime.UtcNow;
        this.dateupdated = DateTime.UtcNow;
    }

    public void Update()
    {
        this.dateupdated = DateTime.UtcNow;
    }
}
