using System;


public enum Rating
{
    Good,
    Great,
    Excellent
}


public struct Dog
    {
        public string name { get; set; }
        public float age { get; set; }
        public string owner { get; set; }
        public Rating rating { get; set; }

        public Dog(string name_str, float age_flo, string owner_str, Rating rating_str)
        {
            name = name_str;
            age = age_flo;
            owner = owner_str;
            rating = rating_str;
        }



}