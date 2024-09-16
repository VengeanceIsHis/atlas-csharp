using System;


public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp < 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;

        this.hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    public delegate void CalculateHealth(float number);

    public void TakeDamage(float damage)
    {
        Console.WriteLine($"{this.name} takes {damage}!");
        if (damage < 0)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
    }

    public void HealDamage(float heal)
    {
        Console.WriteLine($"{this.name} heals {heal} HP!");
        if (heal < 0)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
    }
}