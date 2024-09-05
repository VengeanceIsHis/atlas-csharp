using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        int result = myList[0];
        List<int> temp = new List<int>();
        temp.Add = myList[0];

        for (int i = 1; i < myList.Count; i++)
        {
            if (temp.Contains(myList[i]))
            {
                continue;
            }
            else
            {
            result += myList[i];
            temp.Add(myList[i]);
            }
        }
        return result;
    }
}