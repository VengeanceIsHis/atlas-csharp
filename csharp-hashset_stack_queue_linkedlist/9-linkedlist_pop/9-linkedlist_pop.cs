using System;
using System.Collections.Generic;


class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0;
        }
        LinkedListNode<int> current = myLList.First;
        int value = current.Value;
        myLList.Remove(current);
        return value;
    }
    
}