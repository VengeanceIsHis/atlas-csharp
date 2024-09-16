using System;


public class Player()
{
    public string name { get; private set; }
    public float maxHp { get; private set; }
    public float hp { get; private set; }

    public Player(string name, float maxHp)
    {
        name = name;
        maxHp = 100f;
        hp = maxHp;
    }
}