using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        int result = myList[0];

        for (int i = 1; i < myList.Count; i++)
        {
            result += myList[i];
        }
        return result;
    }
}