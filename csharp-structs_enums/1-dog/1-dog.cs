using System;


public enum Rating
{
    Good,
    Great,
    Excellent
}


public struct Dog
{
    public string Name { get; set; }
    public float Age { get; set; }
    public string Owner { get; set; }
    public Rating Rating { get; set; }

    public Dog(string Name, float Age, string Owner, Rating rating)
    {
        Name = name;
        Age = age;
        Owner = owner;
        Rating = rating;
    }



}