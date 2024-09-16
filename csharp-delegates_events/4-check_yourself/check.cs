using System;


public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    public delegate void CalculateHealth(float number);
    public event EventHandler<CurrentHPArgs> HPCheck;

    public float Hp
    {
        get { return hp; }
        set
        {
            if (hp != value)
            {
                hp = value;
                OnHPCheck(new CurrentHPArgs(hp));
            }
        }
    }
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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

   

    public void TakeDamage(float damage)
    {
        
        if (damage < 0)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {

            float newHp = this.hp;
            newHp -= damage;
            ValidateHP(newHp);
            Console.WriteLine($"{this.name} takes {damage} damage!");
        }
    }

    public void HealDamage(float heal)
    {
        
        if (heal < 0)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            float newHp = this.hp;
            newHp += heal;
            ValidateHP(newHp);
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
    }
    
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
        OnHPCheck(new CurrentHPArgs(this.hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * .5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }

    

    private void CheckStatus(object sender, CurrentHPArgs e)
    {

        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
            Console.WriteLine(this.status);
        }
        else if (e.currentHp == this.maxHp / 2)
        {
            this.status = $"{this.name} is doing well!";
            Console.WriteLine(this.status);
        }
        else if (e.currentHp == this.maxHp / 4 && currentHP == player.maxHp / 2)
        {
            this.status = $"{this.name} isn't doing too great...";
            Console.WriteLine(this.status);
        }
        else if (e.currentHp > 0 && e.currentHp < this.maxHp / 4)
        {
            this.status = $"{this.name} needs help!";
            Console.WriteLine(this.status);
        }
        else
        {
            this.status = $"{this.name} is knocked out!";
            Console.WriteLine(this.status);
        }
    }


    protected virtual void OnHPCheck(CurrentHPArgs e)
    {
        HPCheck?.Invoke(this, e);
    }
}



public enum Modifier
{
    Weak,
    Base,
    Strong
}
public delegate float CalculateModifier(float baseBalue, Modifier modifier);




public class CurrentHPArgs : EventArgs
{
    public float currentHp { get; private set; }

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}