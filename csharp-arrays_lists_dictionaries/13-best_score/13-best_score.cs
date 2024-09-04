using System;
using System.Collections.Generic;


class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bestkey = null;
        int number = 0;

        if (myList.Count == 0)
        {
            return "None";
        }
        foreach (var obj in myList)
        {
            if (obj.Value > number)
            {
                number = obj.Value;
                bestkey = obj.Key;
            }
        }
    return bestkey;
    }
}