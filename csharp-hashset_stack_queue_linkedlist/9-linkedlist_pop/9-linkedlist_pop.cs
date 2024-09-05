using System;
using System.Collections.Generic;


class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        current = myLList.First;
        myLList.Remove(current);
    }
}