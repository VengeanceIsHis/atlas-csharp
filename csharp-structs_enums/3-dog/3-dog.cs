using System;


public enum Rating
{
    Good,
    Great,
    Excellent
}


public struct Dog
    {
        public string name;
        public float age;
        public string owner;
        public Rating rating;

        public Dog(string name_str, float age_flo, string owner_str, Rating rating_str)
        {
            name = name_str;
            age = age_flo;
            owner = owner_str;
            rating = rating_str;
        }


        public override string ToString()
        {
            return $"Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
        }
}