using System;


public class Player()
{
    public string name { get; private set; }
    public float maxHp { get; private set; }
    public float hp { get; private set; }

    public Player(string name, float maxHp)
    {
        this.name = name;
        this.maxHp = maxHp;
        if (this.maxHp < 0)
        {
            this.maxHp = 100f;
        }
        this.hp = maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"<this.name> has <this.hp> / <this.maxHp> health");
    }
}