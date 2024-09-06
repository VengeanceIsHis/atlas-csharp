using System;
using System.Collections.Generic;


class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keycount = 0;
        foreach (var key in myDict.Keys)
        {
            keycount++;
        }
        return keycount;
    }
}