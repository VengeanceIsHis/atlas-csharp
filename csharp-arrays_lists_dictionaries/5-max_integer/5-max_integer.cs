using System;
using System.Collections.Generic;


class List
{
    public static int MaxInteger(List<int> MyList)
    {
        int number = 0;
        for (int i = 0; i < MyList.Count; i++)
        {
            if (MyList[i] > number)
            {
                number = MyList[i];
            }
        }
        return number;
    }
}