using System;
using System.Collections.Generic;


class List
{
    public static int MaxInteger(List<int> MyList)
    {
        int number = int.MinValue;
        if (MyList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
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