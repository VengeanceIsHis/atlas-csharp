using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary{


public static void PrintSorted(Dictionary<string, string> myDict)
{
    myDict = myDict.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);
    
    foreach (var kvp in myDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
}

}